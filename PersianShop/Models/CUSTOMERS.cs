//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersianShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMERS()
        {
            this.cust_act = new HashSet<cust_act>();
            this.sys_users = new HashSet<sys_users>();
        }
    
        public int SHMO { get; set; }
        public string MONAME { get; set; }
        public string code { get; set; }
        public string SHHES { get; set; }
        public string BANKNAME { get; set; }
        public string bankshobe { get; set; }
        public string addre { get; set; }
        public string tell1 { get; set; }
        public string tell2 { get; set; }
        public string cell { get; set; }
        public string active { get; set; }
        public decimal cred { get; set; }
        public decimal man { get; set; }
        public string peygham1 { get; set; }
        public string special { get; set; }
        public Nullable<int> rdf_city { get; set; }
        public int rdf_region { get; set; }
        public int group_rdf { get; set; }
        public string date { get; set; }
        public Nullable<int> sh_i_m { get; set; }
        public string sharh { get; set; }
        public int vis_rdf { get; set; }
        public string user_d { get; set; }
        public Nullable<int> shomare_masir { get; set; }
        public Nullable<int> defi_vis { get; set; }
        public int hesab_status { get; set; }
        public string maxopen_time { get; set; }
        public Nullable<int> check_eteb { get; set; }
        public Nullable<int> just_naghdi { get; set; }
        public Nullable<int> black_list { get; set; }
        public string result_m { get; set; }
        public string c_egh { get; set; }
        public string c_mel { get; set; }
        public string c_pos { get; set; }
        public Nullable<int> kind { get; set; }
        public Nullable<int> IsEmp { get; set; }
        public Nullable<int> MaxManFactor { get; set; }
        public Nullable<int> RDF_masir { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lng { get; set; }
        public string TafsilCode { get; set; }
        public Nullable<int> Ecode_Vis { get; set; }
        public Nullable<int> PersonalityType { get; set; }
        public Nullable<int> EtehadieID { get; set; }
        public string Shenaseh_Egh { get; set; }
        public Nullable<long> TafsilID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<decimal> PriceCheck { get; set; }
        public Nullable<int> CheckDateDay { get; set; }
        public Nullable<int> ShmoMoaref { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cust_act> cust_act { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_users> sys_users { get; set; }
    }
}
