//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineGameShop.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersCart
    {
        public System.Guid UserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
    
        public virtual aspnet_Users aspnet_Users { get; set; }
        public virtual Product Product { get; set; }
    }
}