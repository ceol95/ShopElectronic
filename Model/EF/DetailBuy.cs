//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailBuy
    {
        public int idBuy { get; set; }
        public int idProduct { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> priceOne { get; set; }
    
        public virtual BuyProduct BuyProduct { get; set; }
        public virtual Product Product { get; set; }
    }
}
