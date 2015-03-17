using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Btssio.Musique;
using System.Xml.Linq;

namespace Btssio.Deezer
{
    public static class DeezerApi
    {

        #region champs
        
        private static string url_getDetailsArtistById = "https://api.deezer.com/2.0/artist/#idArtist#&output=xml";

        private static string url_getAllAlbumsByArtist = "https://api.deezer.com/2.0/artist/#idArtist#/albums&output=xml";

        private static string url_getAllTracksByAlbum = "https://api.deezer.com/2.0/album/#idAlbum#/tracks&output=xml";

        #endregion

        #region Méthodes

        #region Traitement des artistes


        /// <summary>
        /// Retourne toutes les informations connues de l'artiste dont l'identifiant est reçu en paramètre.
        /// (ces informations ainsi que sa dicographie complète : tous les morceaux de tous ses albums...)
        /// </summary>
        /// <param name="idArtist">Identifiant de l'artiste.</param>
        /// <returns>Artiste demandé.</returns>
        public static Artist getDetailsArtistById(string idArtist)
        {
            string urlDetailsArtist = url_getDetailsArtistById.Replace("#idArtist#", idArtist);
            
            XElement xArtist = XDocument.Load(urlDetailsArtist).Root;

            Artist theArtist = new Artist(xArtist.Element("id").Value,
                                          xArtist.Element("name").Value,
                                          xArtist.Element("link").Value,
                                          xArtist.Element("picture").Value,
                                          (int)xArtist.Element("nb_album"),
                                          (int)xArtist.Element("nb_fan")                                        
                                          );
                      
            //Récupération de la discographie

            theArtist.lesAlbums = DeezerApi.getAllAlbumsByArtist(theArtist);
            
            
            foreach (Album unAlbum in theArtist.lesAlbums)
            {  
                unAlbum.lesTracks = DeezerApi.getAllTracksByAlbum(unAlbum);
               
            }                        
                    
            return theArtist;
        }
        

       
        #endregion
        
        #region Traitement des albums
               

        /// <summary>
        /// Retourne la liste des albums de l'artiste reçu en paramètre.
        /// </summary>
        /// <param name="theArtist">Artiste concerné.</param>
        /// <returns>Liste des albums de l'artiste.</returns>
        public static List<Album> getAllAlbumsByArtist(Artist theArtist)
        {
            List<Album> lesAlbums = new List<Album>();

            string urlDetailsAlbumsArtist = url_getAllAlbumsByArtist.Replace("#idArtist#", theArtist.id);


            IEnumerable<XElement> xLesAlbums = XDocument.Load(urlDetailsAlbumsArtist).Root.Element("data").Elements("album");
            
            foreach (XElement xUnAlbum in xLesAlbums)
            {               
                //Création de l'album
                Album unAlbum = new Album(xUnAlbum.Element("id").Value,
                                            xUnAlbum.Element("title").Value,
                                            xUnAlbum.Element("cover").Value,
                                            theArtist);
                
                lesAlbums.Add(unAlbum);
           
            }          

            return lesAlbums;
        }
              

        #endregion

        #region Traitement des tracks
        
        /// <summary>
        /// Retourne la liste des morceaux de l'album reçu en paramètre.
        /// </summary>
        /// <param name="theAlbum">Album concerné.</param>
        /// <returns>Liste des morceaux de l'album.</returns>
        public static List<Track> getAllTracksByAlbum(Album theAlbum)
        {
            List<Track> lesTracks = new List<Track>();
            string urlDetailsTracksAlbum = url_getAllTracksByAlbum.Replace("#idAlbum#", theAlbum.id);
            
            IEnumerable<XElement> xLesTracks = XDocument.Load(urlDetailsTracksAlbum).Root.Element("data").Elements("track");
           
            foreach (XElement xUnTrack in xLesTracks)
            {
                XElement xtheArtist = xUnTrack.Element("artist");

                Track unTrack = new Track(xUnTrack.Element("id").Value,
                                     xUnTrack.Element("title").Value,
                                     xUnTrack.Element("link").Value,
                                     (int)xUnTrack.Element("duration"),
                                     xUnTrack.Element("preview").Value,
                                     new Artist(xtheArtist.Element("id").Value,xtheArtist.Element("name").Value),
                                     theAlbum
                                     );
                
              lesTracks.Add(unTrack);
            }

            return lesTracks;
        }
        #endregion

        #endregion
    }
}