using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Btssio.Musique
{
    public class Album
    {
        #region Champs
        /// <summary>
        /// Obtient l'identifiant de l'Album.
        /// </summary>
        private string _id;

        public string id
        {
            get { return _id; }
           private set { _id = value; }
        }
        
       // public string id = "Inconnu";

        /// <summary>
        /// Obtient le titre de l'Album.
        /// </summary>
        private string _title;

        public string title
        {
            get { return _title; }
           private set { _title = value; }
        }
        
        //public string title = "Inconnu";

        /// <summary>
        /// Obtient le lien Deezer de l'Album
        /// </summary>
        private string _link;

        public string link
        {
            get { return _link; }
           private set { _link = value; }
        }
        
       // public string link = "Inconnu";

        /// <summary>
        /// Obtient l'image de la pochette de l'Album
        /// </summary>
        private string _cover;

        public string cover
        {
            get { return _cover; }
           private set { _cover = value; }
        }
        
       // public string cover = "Inconnu";

        /// <summary>
        /// Obtient le label de l'Album
        /// </summary>
        private string _label;

        public string label
        {
            get { return _label; }
           private set { _label = value; }
        }
        
      //  public string label = "inconnu";

        /// <summary>
        /// Obtient la durée de l'Album
        /// </summary>
        private int _duration;

        public int duration
        {
            get { return _duration; }
           private set { _duration = value; }
        }
        
        //public int duration = 0;

        /// <summary>
        /// Obtient le nombre de fans de l'Album.
        /// </summary>
        private int _nbFans;

        public int nbFans
        {
            get { return _nbFans; }
           private set { _nbFans = value; }
        }
        
        //public int nbFans = 0;
        
        /// <summary>
        /// Obtient la date de sortie de l'Album.
        /// </summary>
        private DateTime releaseDate = DateTime.MinValue;

        /// <summary>
        /// Obtient l'Artiste de l'album
        /// </summary>
        public Artist theArtist=new Artist();

        /// <summary>
        /// Obtient la liste des morceaux de l'Album
        /// </summary>
        public List<Track> lesTracks = new List<Track>();

        #endregion
        
        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance par défaut de la classe Album.
        /// Les propriétés de l'album ne peuvent pas être modifiées par la suite.
        /// </summary>
        public Album()
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Album.
        /// </summary>
        /// <param name="id">Identifiant de l'album.</param>
        /// <param name="title">Nom de l'album.</param>
        /// <param name="cover">Url de l'image de l'album.</param>
        
        public Album(string id, string title, string cover)
        {
            this.id = id;
            this.title = title;
            this.cover = cover;
            
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Album.
        /// </summary>
        /// <param name="id">Identifiant de l'album.</param>
        /// <param name="title">Nom de l'album.</param>
        public Album(string id, string title)
        {
            this.id = id;
            this.title = title;           
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Album.
        /// </summary>
        /// <param name="id">Identifiant de l'album.</param>
        /// <param name="title">Nom de l'album.</param>
        /// <param name="cover">Url de l'image de l'album.</param>
        /// <param name="theArtist">Artiste de l'album.</param>
        public Album(string id, string title, string cover, Artist theArtist)
        {
            this.id = id;
            this.title = title;
            this.cover = cover;
            this.theArtist = theArtist;

        }
        
          
       /// <summary>
        /// Initialise une nouvelle instance de la classe Album.
       /// </summary>
        /// <param name="id">Identifiant de l'album.</param>
        /// <param name="title">Nom de l'album.</param>
        /// <param name="link">Lien deezer de l'album</param>
       /// <param name="cover">Pochette de l'album</param>
       /// <param name="label">Label de l'album</param>
       /// <param name="duration">Durée de l'album</param>
       /// <param name="releaseDate">Date de sortie de l'album</param>
       /// <param name="theArtist">Artiste de l'album</param>
        public Album(string id, string title, string link, string cover, string label, int duration, DateTime releaseDate, Artist theArtist)
        {
            this.id = id;
            this.title = title;
            this.link = link;
            this.cover = cover;
            this.label = label;
            this.duration = duration;
            this.releaseDate = releaseDate;
            this.theArtist = theArtist;

        }
        

        #endregion

        #region Méthodes
        /// <summary>
        /// Ajoute un morceau à la liste des morceaux de l'album.
        /// </summary>
        /// <param name="unTrack">Morceau à ajouter.</param>
        public void addTrack(Track unTrack)
        {
            if (lesTracks == null) lesTracks = new List<Track>();
            lesTracks.Add(unTrack);

            unTrack.theAlbum = this;
            unTrack.theArtist = this.theArtist;
        }

        /// <summary>
        /// Obtient la liste des morceaux de l'album.  Null si la liste n'est pas connue.
        /// </summary>
        public List<Track> getLesTracks()
        {
            return lesTracks;
          
        }
        #endregion

        #region Méthodes redéfinies
        /// <summary>
        /// Obtient le nom et l'identifiant de l'album.
        /// </summary>
        /// <returns>Nom suivi de l'identifiant.</returns>
        public override string ToString()
        {
            return title + " (" + id + ")";
        }
        #endregion
    }
}
