//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Esimed.Projet.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableProjet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableProjet()
        {
            this.TableExigence = new HashSet<TableExigence>();
            this.TableJalon = new HashSet<TableJalon>();
        }
    
        public int ProjetId { get; set; }
        public Nullable<int> ProjetAvancement { get; set; }
        public int ProjetTrigramme { get; set; }
        public string ProjetNom { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableExigence> TableExigence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableJalon> TableJalon { get; set; }
        public virtual TableTrigramme TableTrigramme { get; set; }
    }
}
