using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_BIBLIOTHEQUES.BL
{
    class CLS_domaine
    {
        private gestion_bibliothequeEntities3 db;
        private domaine d;

        public bool ajouter_domaine(string libellé)
        {
            db = new gestion_bibliothequeEntities3();
            d = new domaine();

            d.libellé = libellé;
            if (db.domaine.SingleOrDefault(s => s.libellé == libellé) == null)
            {
                db.domaine.Add(d);
                db.SaveChanges();
                return true;

            }
            else
            {
                return false;


            }




        }

        public bool modifier_domaine(int id,string libellé,int id_select)
        {
            db = new gestion_bibliothequeEntities3();
            d = new domaine();
            d = db.domaine.SingleOrDefault(s => s.id_dom == id);
            if (d != null)
            {
              
                d.libellé = libellé;
                db.SaveChanges();
                Console.WriteLine(id+"modifier avec succes");
                return true;
            }
            else
            {
                Console.WriteLine("erreur");
                return false;
            }
           



        }
        public void supprimer_domaine(int id)
        {
            db = new gestion_bibliothequeEntities3();

            d = new domaine();

            d = db.domaine.SingleOrDefault(s => s.id_dom == id);
            if(d!=null)
            {
                db.domaine.Remove(d);
                db.SaveChanges();
            }
            


        }
    }

}
