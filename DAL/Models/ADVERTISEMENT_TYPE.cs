//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADVERTISEMENT_TYPE
    {
        public Nullable<int> USER_ID { get; set; }
        public string ad_type { get; set; }
    
        public virtual LOGIN_PART LOGIN_PART { get; set; }
    }
}
