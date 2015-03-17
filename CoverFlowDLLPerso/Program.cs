using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Btssio.Musique;
namespace ZiKnCo.MoteurRechercheDeezer
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new FrmCoverFlow());

            //Artist monArtiste = new Artist("10","zizou");

            #region Questions

            //REMARQUE : Lorsque cela est nécessaire, ajoutez les versions de constructeurs adéquates
            // N'hésitez pas à placer des points d'arrêts fréquemment pour observer le contenu des objets créés

            // TODO 01. Créer l'artiste suivant :
            // - numéro :  1247440
            // - nom : "django"

            

            // TODO 2. Créer le deuxième artiste suivant :
            // - numéro : 57262
            // - nom : "elvis"
            // - 75 albums

            

            // TODO 3. Ajoutez à django l'album 26 suivant :
            // - nom : "djangologie"
            // - cover : "belle couverture manouche"
            // Rmq : il faut donc créer l'album et l'ajouter à la liste d'albums de l'artiste

            


            // TODO 4. Ajoutez à Elvis l'album 28 nommé "King creole"
            // Rmq : il faut donc créer l'album et l'ajouter à la liste d'albums de l'artiste

           


            // TODO 5. Ajoutez à Django le titre 2692 nommé "Minor Swing"
            // Ce titre appartient à l'album "djangologie" créé précédemment
            // Rmq : il faut donc créer le titre et l'ajouter à l'album associé

            



            // TODO 7. Ajoutez à Elvis le titre 2501 nommé "Jailhouse rock"
            // Ce titre appartient à l'album "King creole" créé précédemment
            // Rmq : il faut donc créer le titre et l'ajouter à l'album associé

            


            // TODO 8. Créer une liste d'artistes nommée "lesArtistes" (vide dans un premier temps)

            


            // TODO 9. Ajoutez à cette liste les 2 artistes créés précédemment

           


            // TODO 10. Affichez dans la fenêtre de sortie (Console.WriteLine()) tous les noms d'artistes de la liste (boucle demandée)

           


            // TODO 11. Affichez dans la fenêtre de sortie tous les noms d'albums de la liste (boucles demandées)
            









            // TODO 12. Affichez dans la console tous les noms de titres de tous les artistes de la liste (boucles demandées)

            













            // TODO 13. Affichez le nom de l'artiste de l'album "djangologie"
            // Si le résultat n'est pas satisfaisant, essayer de trouver pourquoi...
            // Indice : A quel moment faut-il indiquer l'artiste associé à l'album ?

           


            // TODO 14. De la même manière, essayez d'afficher :
            // - le nom de l'album du titre "Minor Swing"
            // - le nom de l'artiste du titre "Minor Swing"
           



            #endregion
            
            #region Questions avec réponses

            ////REMARQUE : Lorsque cela est nécessaire, ajoutez les versions de constructeurs adéquates
            //// N'hésitez pas à placer des points d'arrêts fréquemment pour observer le contenu des objets créés

            //// TODO 01. Créer l'artiste suivant :
            //// - numéro :  1247440
            //// - nom : "django"
            
            Artist djangoArtiste = new Artist("1247440", "django");

            //// TODO 2. Créer le deuxième artiste suivant :
            //// - numéro : 57262
            //// - nom : "elvis"
            //// - 75 albums
            
            Artist elvisArtiste = new Artist("57262", "elvis", 75);

            //// TODO 3. Ajoutez à django l'album 26 suivant :
            //// - nom : "djangologie"
            //// - cover : "belle couverture manouche"
            //// Rmq : il faut donc créer l'album et l'ajouter à la liste d'albums de l'artiste

            Album djangoAlbum = new Album("26","djangologie","belle couverture manouche");
            djangoArtiste.addAlbum(djangoAlbum);

            //// TODO 4. Ajoutez à Elvis l'album 28 nommé "King creole"
            //// Rmq : il faut donc créer l'album et l'ajouter à la liste d'albums de l'artiste

            Album elvisAlbum = new Album("28", "King creole");
            elvisArtiste.addAlbum(elvisAlbum);

            //// TODO 5. Ajoutez à Django le titre 2692 nommé "Minor Swing"
            //// Ce titre appartient à l'album "djangologie" créé précédemment
            //// Rmq : il faut donc créer le titre et l'ajouter à l'album associé
           
            Track djangoTrack = new Track("2692", "Minor Swing");
            djangoAlbum.addTrack(djangoTrack);


            //// TODO 7. Ajoutez à Elvis le titre 2501 nommé "Jailhouse rock"
            //// Ce titre appartient à l'album "King creole" créé précédemment
            //// Rmq : il faut donc créer le titre et l'ajouter à l'album associé

            Track elvisTrack = new Track("2501", "Jailhouse rock");
            elvisAlbum.addTrack(elvisTrack);

            //// TODO 8. Créer une liste d'artistes nommée "lesArtistes" (vide dans un premier temps)
            
            List<Artist> lesArtistes = new List<Artist>();

            //// TODO 9. Ajoutez à cette liste les 2 artistes créés précédemment

            lesArtistes.Add(elvisArtiste);
            lesArtistes.Add(djangoArtiste);

            //// TODO 10. Affichez dans la fenêtre de sortie (Console.WriteLine()) tous les noms d'artistes de la liste d'artistes créés (boucle demandée)

            foreach (Artist unArtiste in lesArtistes)
            {
                Console.WriteLine(unArtiste.name);
            }

            //// TODO 11. Affichez dans la fenêtre de sortie tous les noms d'albums de la liste (boucles demandées)
            foreach (Artist unArtiste in lesArtistes)
            {
                foreach (Album unAlbum in unArtiste.getLesAlbums())
                {
                    Console.WriteLine(unAlbum.title);
                }
            }

            //// TODO 12. Affichez dans la console tous les noms de titres de tous les artistes de la liste (boucles demandées)

            foreach (Artist unArtiste in lesArtistes)
            {
                foreach (Album unAlbum in unArtiste.getLesAlbums())
                {
                    foreach (Track unTrack in unAlbum.getLesTracks())
                    {
                        Console.WriteLine(unTrack.title);
                    }
                }
            }

            //// TODO 13. Affichez le nom de l'artiste de l'album "djangologie"
            //// Si le résultat n'est pas satisfaisant, essayer de trouver pourquoi...
            //// Indice : A quel moment faut-il indiquer l'artiste associé à l'album ?

            Console.WriteLine(djangoAlbum.theArtist.name);

            //// TODO 14. De la même manière, essayez d'afficher :
            //// - le nom de l'album du titre "Minor Swing"
            //// - le nom de l'artiste du titre "Minor Swing"
            Console.WriteLine(djangoTrack.theAlbum.title);
            Console.WriteLine(djangoTrack.theArtist.name);
            
            #endregion
        }
    }
}