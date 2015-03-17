using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Btssio.Musique;
using Btssio.Deezer;

using CDI.IndexCard3D; // pour le cover flow
using System.Net; // pour le download d'image à partir d'Uri

namespace ZiKnCo.MoteurRechercheDeezer
{
    public partial class FrmCoverFlow : Form
    {
        #region champs

        private List<Album> lesAlbums = new List<Album>();
        private List<Track> lesTracks = new List<Track>();

        public Artist selectedArtistDetails = new Artist();
        
        #endregion

        #region constructeurs
        
        public FrmCoverFlow()
        {
            InitializeComponent();
            //selectedArtistDetails = DeezerApi.getArtistById("71069", OptionArtistLookup.discography___discography_details);
        }

        #endregion

        #region méthodes gestionnaire d'événement

        #region méthodes liées au COVER FLOW (IC3D)

        private void iC3DAlbums_RenderText(object sender, EventArgs e)
        {
            Font fntNom = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font fntTitre = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Pixel);

            string titre = iC3DAlbums.IndexCards.ElementAt(iC3DAlbums.ActiveCard - 1).Title;

            // On dessine les textes dans le cover flow (nom de l'artiste et titre de l'album)
            iC3DAlbums.DrawText(0, iC3DAlbums.Height - 75, selectedArtistDetails.name, IC3D.TextAlignment.Center, fntNom, Color.FloralWhite);
            iC3DAlbums.DrawText(0, iC3DAlbums.Height - 45, titre, IC3D.TextAlignment.Center, fntTitre, Color.Wheat);
        }

        private void iC3DAlbums_IndexCardChanged(object sender, IndexCardEventArgs e)
        {
            chargerTitresSelectedAlbum();
        }


        #endregion


        private void frmCoverFlow_Load(object sender, EventArgs e)
        {
            selectedArtistDetails = DeezerApi.getDetailsArtistById("71069");
            
            lesAlbums = selectedArtistDetails.getLesAlbums();
            
            // On utilise un WebClient pour télécharger les images des pochettes d'album
            // (le cover flow ne peut afficher que des images locales)
            WebClient wClient = new WebClient();
            string nomImage;
            int i;

            for (i = 0; i < lesAlbums.Count; i++)
            {
                nomImage = "image" + i + ".jpg";

                //Téléchargement de l'image de l'artiste pour affichage dans le cover flow
                wClient.DownloadFile(lesAlbums[i].cover, nomImage);

                //Création de la vignette d'album (pochette). Premier paramètre : titre (title)
                Card c = new Card(lesAlbums[i].title, nomImage);

                //Ajout au cover flow
                iC3DAlbums.IndexCards.Add(c);
                 
            }

            iC3DAlbums.IndexCards.LoadTexturesToMemory();
            // Lorsque le cover flow est affiché, on charge les titres du premier album
            chargerTitresSelectedAlbum();

         //   wmpLecteur.CurrentItemChange -= new EventHandler(wmpLecteur_CurrentItemChange);
         }

        private void wmpLecteur_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            lblTitre.Text = wmpLecteur.currentMedia.getItemInfo("nomTitre");
            lblXsurY.Text = wmpLecteur.currentMedia.getItemInfo("XsurY") + " sur " + lesTracks.Count;
            lstTitres.SelectedIndex = Convert.ToInt16(wmpLecteur.currentMedia.getItemInfo("XsurY")) - 1;
        }

        private void lblXsurY_MouseHover(object sender, EventArgs e)
        {
            panListeTitres.Visible = true;
        }

        private void lstTitres_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia unMedia = wmpLecteur.currentPlaylist.get_Item(lstTitres.SelectedIndex);

            wmpLecteur.Ctlcontrols.playItem(unMedia);
        }

        private void lstTitres_MouseLeave(object sender, EventArgs e)
        {
            panListeTitres.Visible = false;
        }


        #endregion

        #region méthodes

        private void chargerTitresSelectedAlbum()
        {
            Cursor.Current = Cursors.WaitCursor;

            //Remarque : ActiveCard commence à 1, les éléments de "lesAlbums" à 0...
            Album selectedAlbum = lesAlbums.ElementAt(iC3DAlbums.ActiveCard - 1); 

            lesTracks = selectedAlbum.getLesTracks();

            lstTitres.DataSource = lesTracks;
            lstTitres.DisplayMember = "name";

            int indexTitre = 1;

            //on vide la playlist
            wmpLecteur.currentPlaylist.clear();

            //Chargement de la playlist avec chaque titre de l'album
            foreach (Track unTrack in lesTracks)
            {
                WMPLib.IWMPMedia unMedia = wmpLecteur.newMedia(unTrack.preview);

                unMedia.setItemInfo("nomTitre", unTrack.title);
                unMedia.setItemInfo("xSurY", indexTitre.ToString());
                indexTitre++;

                wmpLecteur.currentPlaylist.appendItem(unMedia);
            }
        }

        #endregion
        
    }
}
