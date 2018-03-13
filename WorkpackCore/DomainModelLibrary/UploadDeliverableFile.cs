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
    
    public partial class UploadDeliverableFile
    {
        public UploadDeliverableFile()
        {
            this.FileCheckers = new HashSet<FileChecker>();
            this.PageCommentDetails = new HashSet<PageCommentDetail>();
            this.PageDetails = new HashSet<PageDetail>();
            this.PageTextDetails = new HashSet<PageTextDetail>();
        }
    
        public int UploadDeliverableFileID { get; set; }
        public string FilePath { get; set; }
        public Nullable<int> DeliverableListID { get; set; }
        public string FileName { get; set; }
        public Nullable<int> MilestoneID { get; set; }
        public Nullable<int> RevisionID { get; set; }
        public string FileExtention { get; set; }
        public Nullable<int> FileSize { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int Status { get; set; }
        public string IsConfidential { get; set; }
        public int Dwgfileid { get; set; }
        public Nullable<int> Version { get; set; }
        public string ApprovedRemark { get; set; }
    
        public virtual ICollection<FileChecker> FileCheckers { get; set; }
        public virtual ICollection<PageCommentDetail> PageCommentDetails { get; set; }
        public virtual ICollection<PageDetail> PageDetails { get; set; }
        public virtual ICollection<PageTextDetail> PageTextDetails { get; set; }
    }
}