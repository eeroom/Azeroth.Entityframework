// Code generated by a template
using System;
using System.ComponentModel.DataAnnotations;

namespace EF.T4.Mssql.ZS
{
    public partial class GZ_Bonus
    {
        /// <summary>
        ///
        /// </summary>
        [Key]
        public Guid Id {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Guid EmployeeId {set;get;}
        /// <summary>
        ///
        /// </summary>
        [Required]
        [StringLength(200)]
        public String Money {set;get;}
        /// <summary>
        ///
        /// </summary>
        public DateTime StartDate {set;get;}
        /// <summary>
        ///
        /// </summary>
        public DateTime EndDate {set;get;}
        /// <summary>
        ///
        /// </summary>
        [Required]
        [StringLength(1024)]
        public String Comment {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Int32 Status {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Guid DepartmentId {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Guid FinancailUnitId {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Guid CompanyId {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Nullable<Guid> LastUpdateUser {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Nullable<DateTime> LastUpdateDate {set;get;}
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
