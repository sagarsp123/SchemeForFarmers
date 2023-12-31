//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgriFarmProj.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblCropRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCropRequest()
        {
            this.tblBiddings = new HashSet<tblBidding>();
        }

        [DataMember]
        public int Requestid { get; set; }
        [DataMember]
        public Nullable<int> Farmerid { get; set; }
        [DataMember]
        public string CropType { get; set; }
        [DataMember]
        public string CropName { get; set; }
        [DataMember]
        public string FertilizerType { get; set; }
        [DataMember]
        public Nullable<decimal> Quantity { get; set; }
        [DataMember]
        public string SoilPhCertificate { get; set; }
        [DataMember]
        public Nullable<bool> CropApproved { get; set; }
        [DataMember]
        public Nullable<int> ApprovalAdminId { get; set; }
    
        public virtual tblAdmin tblAdmin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBidding> tblBiddings { get; set; }
        public virtual tblFarmer tblFarmer { get; set; }
    }
}
