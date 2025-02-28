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
    
    public partial class Users
    {
        public Users()
        {
            this.CashIns = new HashSet<CashIns>();
            this.News = new HashSet<News>();
            this.Referrals = new HashSet<Referrals>();
            this.Referrals1 = new HashSet<Referrals>();
            this.Wallets = new HashSet<Wallets>();
            this.Roles = new HashSet<Roles>();
        }
    
        public System.Guid ApplicationId { get; set; }
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public bool IsAnonymous { get; set; }
        public System.DateTime LastActivityDate { get; set; }
        public string Pwd { get; set; }
        public int PublicId { get; set; }
        public string Communication { get; set; }
        public double ReffAdd { get; set; }
        public string Icq { get; set; }
        public string VkontakteId { get; set; }
        public string Skype { get; set; }
    
        public virtual Applications Applications { get; set; }
        public virtual ICollection<CashIns> CashIns { get; set; }
        public virtual Memberships Memberships { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Referrals> Referrals { get; set; }
        public virtual ICollection<Referrals> Referrals1 { get; set; }
        public virtual ICollection<Wallets> Wallets { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
    }
}
