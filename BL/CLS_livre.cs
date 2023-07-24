using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_BIBLIOTHEQUES.BL
{
    class CLS_livre
    {
        private gestion_bibliothequeEntities3 db;
        private livre l;
        private domaine d;
        private abonnée a;
        public bool ajouter_livre(string titre, string editeur,string auteur, int nombre_pages,int prix,string libellé,DateTime année_publication)
        {
            var id=
            db = new gestion_bibliothequeEntities3();
            l = new livre();
            d = new domaine();
            l.titre = titre; 
            l.editeur = editeur;
            l.nombre_pages = nombre_pages;
            l.auteur = auteur;
            l.annee_publication = année_publication;
            l.prix = prix;
            l.empruneter = false;
            l.id_abonnée = null;
            var listedomaine = db.domaine.ToList();
            foreach (var element in listedomaine)
            {
                if (element.libellé == libellé)
                    l.id_dom = element.id_dom;

            }
                db.livre.Add(l);
            db.SaveChanges();
            return true;





        }
        public bool modifier_livre(int id, string titre, string editeur, string auteur, int nombre_pages, int prix, string libellé, DateTime année_publication, string emprunter,string abonnée)
        {
            db = new gestion_bibliothequeEntities3();
           
            l = new livre();
            a = new abonnée();
            l = db.livre.SingleOrDefault(s => s.id_livre == id);
            if (l != null)
            {
                d = new domaine();
                l.titre = titre;
                l.editeur = editeur;
                l.nombre_pages = nombre_pages;
                l.auteur = auteur;
                l.annee_publication = année_publication;
                l.prix = prix;
                PL.ajouter_modifier_livre aj = new PL.ajouter_modifier_livre();
                if (aj.textBox7.Text == "non emprunter")
                {
                    l.empruneter = false;
                    l.id_abonnée = null;
                }
                else
                    l.empruneter = true;
                foreach (var a in db.abonnée)
                    if (a.nom == abonnée)
                        l.id_abonnée = a.id_abonnée;
                var listedomaine = db.domaine.ToList();
                foreach (var element in listedomaine)
                {
                    if (element.libellé == libellé)
                        l.id_dom = element.id_dom;

                }

                db.SaveChanges();
                Console.WriteLine(id + "modifier avec succes");
                return true;
            }
            else
            {
                Console.WriteLine("erreur");
                return false;
            }




        }
        public void supprimer_livre(int id)
        {
            db = new gestion_bibliothequeEntities3();

            l = new livre();

            l = db.livre.SingleOrDefault(s => s.id_livre == id);
            if (l != null)
            {

                db.livre.Remove(l);
                db.SaveChanges();
            }



        }


    }
}
