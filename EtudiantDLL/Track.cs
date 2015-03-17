using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Btssio.Musique
{
    public class Track
    {
        #region Champs
        /// <summary>
        /// Obtient l'identifiant du morceau.
        /// </summary>
        public string id = "Inconnu";

        /// <summary>
        /// Obtient le titre du morceau.
        /// </summary>
        public string title = "Inconnu";

        /// <summary>
        /// Obtient l'Album du morceau.
        /// </summary>
        public Album theAlbum = null;

        /// <summary>
        /// Obtient le lien Deezer vers le morceau.
        /// </summary>
        public string link = "Inconnu";

        /// <summary>
        /// Obtient la durée du morceau.
        /// </summary>
        public int duration = 0;

        /// <summary>
        /// Obtient un extrait de 30 secondes du morceau.
        /// </summary>
        public string preview = "Inconnu";

        /// <summary>
        /// Obtient l'Artiste du morceau.
        /// </summary>
        public Artist theArtist;
        #endregion
                
        #region Constructeurs
        /// <summary>
        /// Initialise une nouvelle instance par défaut de la classe Track.
        /// Les propriétés du morceau ne peuvent pas être modifiées par la suite.
        /// </summary>
        public Track()
        {
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Track.
        /// </summary>
        /// <param name="id">Identifiant du morceau.</param>
        /// <param name="title">Nom du morceau.</param>
        /// <param name="link">Uri vers un détail du morceau.</param>
        /// <param name="duration">Durée du morceau.</param>
        /// <param name="preview">Uri vers un extrait du morceau.</param>
        /// <param name="theArtist">Artiste du morceau.</param>
        /// <param name="theAlbum">Album du morceau.</param>
        public Track(string id, string title, string link, int duration, string preview, Artist theArtist, Album theAlbum)
        {
            this.id = id;
            this.title = title;
            this.link = link;
            this.duration = duration;
            this.preview = preview;
            this.theArtist = theArtist;
            this.theAlbum = theAlbum;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Track.
        /// </summary>
        /// <param name="id">Identifiant du morceau.</param>
        /// <param name="title">Nom du morceau.</param>
        public Track(string id, string title)
        {
            this.id = id;
            this.title = title;            
        }

        #endregion

        #region Méthodes redéfinies
        /// <summary>
        /// Obtient le nom de l'artiste.
        /// </summary>
        /// <returns>Nom de l'artiste.</returns>
        public override string ToString()
        {
            return title;
        }
        #endregion
    }
}
