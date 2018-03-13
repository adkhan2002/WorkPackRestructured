//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public Client()
        {
            this.ClientAssets = new HashSet<ClientAsset>();
            this.ClientContracts = new HashSet<ClientContract>();
            this.ClientFocalPoints = new HashSet<ClientFocalPoint>();
        }
    
        public int ClientID { get; set; }
        public string Clientname { get; set; }
        public string ClientCode { get; set; }
        public Nullable<int> CompanyId { get; set; }
    
        public virtual ICollection<ClientAsset> ClientAssets { get; set; }
        public virtual ICollection<ClientContract> ClientContracts { get; set; }
        public virtual ICollection<ClientFocalPoint> ClientFocalPoints { get; set; }
    }
}