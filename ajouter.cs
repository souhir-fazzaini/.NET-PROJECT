//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GESTION_BIBLIOTHEQUES
{
    using System;
    using System.Collections.Generic;
    
    public partial class ajouter
    {
        public int id_employé { get; set; }
        public int is_livre { get; set; }
        public Nullable<int> id_abonnée { get; set; }
        public Nullable<int> is_dom { get; set; }
    
        public virtual abonnée abonnée { get; set; }
        public virtual domaine domaine { get; set; }
        public virtual employé employé { get; set; }
        public virtual livre livre { get; set; }
    }
}
