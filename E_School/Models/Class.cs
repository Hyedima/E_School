//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_School.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Class
    {
        public string ClassID { get; set; }
        public string CategoryID { get; set; }
        public string Name { get; set; }
    
        public virtual ClassCategory ClassCategory { get; set; }
    }
}
