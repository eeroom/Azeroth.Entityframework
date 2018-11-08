// Code generated by a template
using System;
using System.ComponentModel.DataAnnotations;

namespace EF.T4.Mssql
{
    public partial class GZ_SocialMoneyDetailSZ
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
        public String Account {set;get;}
        /// <summary>
        ///
        /// </summary>
        [Required]
        [StringLength(50)]
        public String Name {set;get;}
        /// <summary>
        ///
        /// </summary>
        [Required]
        [StringLength(50)]
        public String IDCard {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal TotalMoney {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal TotalPesonal {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal TotalCorp {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal YangLaoGeRen {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal YangLaoDanWei {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal YangLaoJiShu {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal GongShangGeRen {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal GongShangDanWei {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal GongShangJiShu {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal ShiYeGeRen {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal ShiYeDanWei {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal ShiYeJiShu {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal YiLiaoGeRen {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal YiLiaoDanWei {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal YiLiaoJiShu {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal ShenYuGeRen {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal ShenYuDanWei {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Decimal ShenYuJiShu {set;get;}
        /// <summary>
        ///
        /// </summary>
        public Guid MasterId {set;get;}
    }

}
// It's the end
