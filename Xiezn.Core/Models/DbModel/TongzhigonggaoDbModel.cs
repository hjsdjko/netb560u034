using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 通知公告
    /// </summary>
    [SugarTable("tongzhigonggao")]
	public class TongzhigonggaoDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 标题
		/// </summary>
		[SugarColumn(ColumnName = "biaoti")]
		public string Biaoti { get; set; }

		/// <summary>
		/// Desc: 封面
		/// </summary>
		[SugarColumn(ColumnName = "fengmian")]
		public string Fengmian { get; set; }

		/// <summary>
		/// Desc: 简介
		/// </summary>
		[SugarColumn(ColumnName = "jianjie")]
		public string Jianjie { get; set; }

		/// <summary>
		/// Desc: 内容
		/// </summary>
		[SugarColumn(ColumnName = "neirong")]
		public string Neirong { get; set; }

		/// <summary>
		/// Desc: 发布日期
		/// </summary>
        [SugarColumn(ColumnName = "faburiqi")]
		[JsonConverter(typeof(Common.Helpers.DateFormatConverter), "yyyy-MM-dd")]
		public DateTime Faburiqi { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
