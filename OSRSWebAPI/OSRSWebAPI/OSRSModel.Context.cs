﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OSRSWebAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OSRSEntities : DbContext
    {
        public OSRSEntities()
            : base("name=OSRSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItemMapping> CartItemMappings { get; set; }
        public virtual DbSet<OrderItemMapping> OrderItemMappings { get; set; }
        public virtual DbSet<OrderTable> OrderTables { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    
        public virtual int addPaymentTransactions(string nameOnCard, Nullable<int> cardNumber, Nullable<int> cvv, string netbankingName, Nullable<int> order_id, Nullable<int> userid, Nullable<System.DateTime> expiryDate, Nullable<double> amount)
        {
            var nameOnCardParameter = nameOnCard != null ?
                new ObjectParameter("nameOnCard", nameOnCard) :
                new ObjectParameter("nameOnCard", typeof(string));
    
            var cardNumberParameter = cardNumber.HasValue ?
                new ObjectParameter("cardNumber", cardNumber) :
                new ObjectParameter("cardNumber", typeof(int));
    
            var cvvParameter = cvv.HasValue ?
                new ObjectParameter("cvv", cvv) :
                new ObjectParameter("cvv", typeof(int));
    
            var netbankingNameParameter = netbankingName != null ?
                new ObjectParameter("netbankingName", netbankingName) :
                new ObjectParameter("netbankingName", typeof(string));
    
            var order_idParameter = order_id.HasValue ?
                new ObjectParameter("order_id", order_id) :
                new ObjectParameter("order_id", typeof(int));
    
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            var expiryDateParameter = expiryDate.HasValue ?
                new ObjectParameter("expiryDate", expiryDate) :
                new ObjectParameter("expiryDate", typeof(System.DateTime));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addPaymentTransactions", nameOnCardParameter, cardNumberParameter, cvvParameter, netbankingNameParameter, order_idParameter, useridParameter, expiryDateParameter, amountParameter);
        }
    
        public virtual ObjectResult<ViewProducts_Result> ViewProducts(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewProducts_Result>("ViewProducts", useridParameter);
        }
    
        public virtual ObjectResult<getcartitemmapping_Result> getcartitemmapping(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getcartitemmapping_Result>("getcartitemmapping", useridParameter);
        }
    
        public virtual ObjectResult<getcartitemmappingv2_Result> getcartitemmappingv2(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getcartitemmappingv2_Result>("getcartitemmappingv2", useridParameter);
        }
    
        public virtual ObjectResult<getcartitemmappingv3_Result> getcartitemmappingv3(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getcartitemmappingv3_Result>("getcartitemmappingv3", useridParameter);
        }
    }
}
