using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Btssio.Musique
{
    /// <summary>
    /// Classe Artist
    /// </summary>
    public class Artist
    {
        #region Champs

        /// <summary>
        /// Identifiant de l'artiste.
        /// </summary>
        private string _id;

        public string id
        {
            get { return _id; }
            private set { _id = value; }
        }
        
        ///string id = "Inconnu";

        /// <summary>
        /// Nom de l'artiste.
        /// </summary>
        private string _name;

        public string name
        {
            get { return _name; }
            private set { _name = value; }
        }
        
       /// public string name = "Inconnu";

        /// <summary>
        /// Lien de la page deezer de l'artiste.
        /// </summary>
        private string _link;

        public string link
        {
            get { return _link; }
            private set { _link = value; }
        }
        
       // public string link = "Inconnu";

        /// <summary>
        /// Lien de l'image de l'artiste.
        /// </summary>
        private string _picture;

        public string picture
        {
            get { return _picture; }
            private set { _picture = value; }
        }
        
        ///public string picture = "Inconnu";

        /// <summary>
        /// Nombre d'albums de l'artiste.
        /// </summary>
        private int _nbAlbums;

        public int nbAlbums
        {
            get { return _nbAlbums; }
            private set { _nbAlbums = value; }
        }
        
        ///public int nbAlbums = 0;

        /// <summary>
        /// Nombre de fans de l'artiste.
        /// </summary>
        private int _nbFAns;

        public int nbFans
        {
            get { return _nbFAns; }
            private set { _nbFAns = value; }
        }
        
        ///public int nbFans = 0;

        /// <summary>
        /// Liste des albums de l'artiste.
        /// </summary>
        public List<Album> lesAlbums=new List<Album>();
        
        /// <summary>
        /// Liste des artistes en relation avec l'artiste.
        /// </summary>
        public List<Artist> relatedArtists=new List<Artist>();
        #endregion
                    
        #region Constructeurs

        /// <summary>
        /// Initialise une nouvelle instance par défaut de la classe Artist.
        /// Les propriétés de l'artiste ne peuvent pas être modifiées par la suite.
        /// </summary>
        public Artist()
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Artist.
        /// </summary>
        /// <param name="id">Identifiant de l'artiste</param>
        /// <param name="name">Nom de l'artiste</param>
        
        public Artist(string id, string name)
        {
            this.id = id;
            this.name = name;
            
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Artist.
        /// </summary>
        /// <param name="id">Identifiant de l'artiste</param>
        /// <param name="name">Nom de l'artiste</param>
        /// <param name="nbAlbums">Nombre d'albums de l'artiste</param>
        public Artist(string id, string name, int nbAlbums)
        {
            this.id = id;
            this.name = name;
            this.nbAlbums = nbAlbums;

        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Artist.
        /// </summary>
        /// <param name="id">Identifiant de l'artiste</param>
        /// <param name="name">Nom de l'artiste</param>
        /// <param name="link">Lien de détail de l'artiste.</param>
        /// <param name="picture">Lien de l'image de l'artiste</param>
        public Artist(string id, string name, string link, string picture)
        {
            this.id = id;
            this.name = name;
            this.link = link;
            this.picture = picture;

        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Artist.
        /// </summary>
        /// <param name="id">Identifiant de l'artiste.</param>
        /// <param name="name">Nom de l'artiste.</param>
        /// <param name="link">Uri de détail de l'artiste.</param>
        /// <param name="picture">Uri d'une photo de l'artiste.</param>
        /// <param name="nbAlbums">Nombre d'albums de l'artiste.</param>
        /// <param name="nbFans">Nombre de fans de l'artiste.</param>
        public Artist(string id, string name, string link, string picture, int nbAlbums, int nbFans)
        {
            this.id = id;
            this.name = name;
            this.link = link;
            this.picture = picture;
            this.nbAlbums = nbAlbums;
            this.nbFans = nbFans;

        }

        #endregion

        #region Méthodes
        /// <summary>
        /// Ajoute un album à la liste des albums de l'artiste.
        /// </summary>
        /// <param name="unAlbum">Album à ajouter à la liste.</param>
        public void addAlbum(Album unAlbum)
        {
            if (lesAlbums == null)
                lesAlbums = new List<Album>();
            lesAlbums.Add(unAlbum);            
            nbAlbums++;

            unAlbum.theArtist = this;
        }

        /// <summary>
        /// Ajoute un artiste en relation à la liste des artiste en relation de l'artiste.
        /// </summary>
        /// <param name="unArtist">Album à ajouter à la liste.</param>
        public void addRelatedArtists(Artist unArtist)
        {
            if (relatedArtists == null) relatedArtists = new List<Artist>();
            relatedArtists.Add(unArtist);
        }

        /// <summary>
        /// Obtient une copie de la liste des albums de l'artiste.  Null si la liste des albums n'est pas connue.
        /// </summary>
        public List<Album> getLesAlbums()
        {
            return lesAlbums;

        }

        /// <summary>
        /// Obtient une copie de la liste des artistes similaires à l'artiste. Null si la liste des artistes similaires n'est pas connue.
        /// </summary>
        public List<Artist> getRelatedArtists()
        {
            return relatedArtists;

        }
        #endregion

        #region Méthodes redéfinies
        /// <summary>
        /// Obtient le nom de l'artiste.
        /// </summary>
        /// <returns>Nom de l'artiste.</returns>
        public override string ToString()
        {
            return name;
        }

        #endregion
    }
}