//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConcoursCanin
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHIEN()
        {
            this.PARTICIPE = new HashSet<PARTICIPE>();
        }
    
        public string codechien { get; set; }
        public string codeproprietaire { get; set; }
        public Nullable<System.DateTime> ddnchien { get; set; }
        public string nomchien { get; set; }
    
        public virtual PROPRIETAIRE PROPRIETAIRE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARTICIPE> PARTICIPE { get; set; }
    }
}
