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
    
    public partial class usp_GetOverTimeRequestForApprove_Result
    
    {
        public int OverTimeRequestID { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string TaskName { get; set; }
        public string ProjectCode { get; set; }
        public int TaskID { get; set; }
        public decimal OtHours { get; set; }
        public string OTStatus { get; set; }
        public int ApproverID { get; set; }
        public string ApproveStatus { get; set; }
        public Nullable<decimal> AllottedHours { get; set; }
        public string OtJustification { get; set; }
        public Nullable<int> TaskStatus { get; set; }
    }
}