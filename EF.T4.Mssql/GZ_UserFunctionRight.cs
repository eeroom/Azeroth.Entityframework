// Code generated by a template
using System;
using System.ComponentModel.DataAnnotations;

namespace EF.T4.Mssql
{
    public partial class GZ_UserFunctionRight
    {
        /// <summary>
        ///
        /// </summary>
        [Key]
        public Guid Id {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Guid UserId {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Guid FunctionId {set;get;}
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
