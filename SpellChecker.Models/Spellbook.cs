//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpellChecker.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spellbook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Spellbook()
        {
            this.SpellbookEntries = new HashSet<SpellbookEntry>();
        }
    
        public int SpellbookId { get; set; }
        public string SpellbookName { get; set; }
        public string UserId { get; set; }
    
        public virtual ApplicationUser ApplicationUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpellbookEntry> SpellbookEntries { get; set; }
    }
}
