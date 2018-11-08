// Code generated by a template
using System;
using System.ComponentModel.DataAnnotations;

namespace EF.T4.Mssql
{
    public partial class GZ_HouseMoneyMaster
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
        public String Month {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Int32 Status {set;get;}
        /// <summary>
        ///
        /// </summary>
        [Required]
        [StringLength(512)]
        public String FilePath {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Int32 Template {set;get;}
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
