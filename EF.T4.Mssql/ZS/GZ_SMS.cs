// Code generated by a template
using System;
using System.ComponentModel.DataAnnotations;

namespace EF.T4.Mssql.ZS
{
    public partial class GZ_SMS
    {
        /// <summary>
        ///
        /// </summary>
        [Key]
        public Guid Id {set;get;}
        /// <summary>
        ///
        /// </summary>
        [Required]
        [StringLength(50)]
        public String Mobile {set;get;}
        /// <summary>
        ///
        /// </summary>
        [Required]
        [StringLength(500)]
        public String RequestBody {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Int32 TemplateId {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Int32 Status {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Int32 SendTimes {set;get;}
        /// <summary>
        ///
        /// </summary>
        [StringLength(2048)]
        public String ApiResult {set;get;}
        /// <summary>
        ///
        /// </summary>
        [Required]
        [StringLength(500)]
        public String FullContent {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Nullable<Guid> CreateUser {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Nullable<DateTime> CreateDate {set;get;}
    }

}
// It's the end
