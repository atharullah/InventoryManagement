//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagement.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seller
    {
        public long SellerID { get; set; }
        public string SellerName { get; set; }
        public string SellerMobile { get; set; }
        public string SellerLandline { get; set; }
        public string SellerEmail { get; set; }
        public string SellerAddress { get; set; }
        public string VATNo { get; set; }
        public string TINNo { get; set; }
        public string AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}