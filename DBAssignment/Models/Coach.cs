//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBAssignment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coach
    {
        public int Coach_Id { get; set; }
        public string Coach_Fname { get; set; }
        public string Coach_Lanme { get; set; }
        public string Coach_Phone { get; set; }
        public int Team_Id { get; set; }
    
        public virtual Team Team { get; set; }
    }
}