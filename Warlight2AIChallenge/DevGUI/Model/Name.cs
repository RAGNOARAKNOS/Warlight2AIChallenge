//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevGUI.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Name
    {
        public Name()
        {
            this.AddressMaps = new HashSet<AddressMap>();
            this.Emails = new HashSet<Email>();
        }
    
        public int NameID { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
    
        public virtual ICollection<AddressMap> AddressMaps { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
    }
}