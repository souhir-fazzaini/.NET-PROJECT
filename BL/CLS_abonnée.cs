using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_BIBLIOTHEQUES.BL
{
    class CLS_abonnée
    {
        private gestion_bibliothequeEntities3 db;
        private abonnée a;

        public bool ajouter_abonnée(string nom,string prenom,DateTime année_naissance,string nationnalité)
        {
            db = new gestion_bibliothequeEntities3();
            a = new abonnée();
            a.nom = nom;
            a.prenom = prenom;
            a.date_naissance = année_naissance;
            a.nationnalité = nationnalité;

            
                db.abonnée.Add(a);
                db.SaveChanges();
                return true;

           



        }
        public bool modifier_abonnée(int id,string nom, string prenom, DateTime année_naissance, string nationnalité)
        {
            db = new gestion_bibliothequeEntities3();
            a = new abonnée();
            a = db.abonnée.SingleOrDefault(s => s.id_abonnée== id);
            if (a != null)
            {
                a.nom = nom;
                a.prenom = prenom;
                a.date_naissance = année_naissance;
                a.nationnalité = nationnalité;
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
        public void supprimer_abonnée(int id)
        {
            db = new gestion_bibliothequeEntities3();

            a = new abonnée();

            a = db.abonnée.SingleOrDefault(s => s.id_abonnée == id);
            if (a != null)
            {
                db.abonnée.Remove(a);
                db.SaveChanges();
            }



        }


    }
}
