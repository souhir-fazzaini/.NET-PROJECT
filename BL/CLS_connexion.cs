using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_BIBLIOTHEQUES.BL
{
    class CLS_connexion
    {
        public bool ConnexionValide(gestion_bibliothequeEntities3 db,string nom,string motdepasse)
        {
            employé e = new employé();
            e.nom = nom;
            e.motdepasse = motdepasse;
            if(db.employé.SingleOrDefault(s=>s.nom==nom && s.motdepasse==motdepasse)!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
