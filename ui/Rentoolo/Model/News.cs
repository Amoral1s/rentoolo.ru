//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public System.DateTime Date { get; set; }
        public System.Guid AuthorId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
