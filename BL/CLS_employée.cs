using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_BIBLIOTHEQUES.BL
{
    class CLS_employée
    {
        private gestion_bibliothequeEntities3 db;
        private employé e;

        public bool ajouter_employé(string nom, string prenom, DateTime année_naissance, string nationnalité,string motdepasse)
        {
            db = new gestion_bibliothequeEntities3();
           e = new employé();
            e.nom = nom;
            e.prenom = prenom;
            e.date_naissance = année_naissance;
            e.nationnalité = nationnalité;
            e.motdepasse = motdepasse;
            db.employé.Add(e);
            db.SaveChanges();
            return true;





        }
        public bool modifier_employé(int id, string nom, string prenom, DateTime année_naissance, string nationnalité,string motdepasse)
        {
            db = new gestion_bibliothequeEntities3();
            e = new employé();
            e = db.employé.SingleOrDefault(s => s.id_employé== id);
            if (e != null)
            {
                e.nom = nom;
                e.prenom = prenom;
                e.date_naissance = année_naissance;
                e.nationnalité = nationnalité;
                e.motdepasse = motdepasse;
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
        public void supprimer_employé(int id)
        {
            db = new gestion_bibliothequeEntities3();

            e = new employé();

             e = db.employé.SingleOrDefault(s => s.id_employé == id);
            if (e != null)
            {
                db.employé.Remove(e);
                db.SaveChanges();
            }



        }



    }
}
