using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 作业信息
    /// </summary>
    [SugarTable("zuoyexinxi")]
	public class ZuoyexinxiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 课程名称
		/// </summary>
		[SugarColumn(ColumnName = "kechengmingcheng")]
		public string Kechengmingcheng { get; set; }

		/// <summary>
		/// Desc: 作业名称
		/// </summary>
		[SugarColumn(ColumnName = "zuoyemingcheng")]
		public string Zuoyemingcheng { get; set; }

		/// <summary>
		/// Desc: 作业要求
		/// </summary>
		[SugarColumn(ColumnName = "zuoyeyaoqiu")]
		public string Zuoyeyaoqiu { get; set; }

		/// <summary>
		/// Desc: 学号
		/// </summary>
		[SugarColumn(ColumnName = "xuehao")]
		public string Xuehao { get; set; }

		/// <summary>
		/// Desc: 学生姓名
		/// </summary>
		[SugarColumn(ColumnName = "xueshengxingming")]
		public string Xueshengxingming { get; set; }

		/// <summary>
		/// Desc: 工号
		/// </summary>
		[SugarColumn(ColumnName = "gonghao")]
		public string Gonghao { get; set; }

		/// <summary>
		/// Desc: 教师姓名
		/// </summary>
		[SugarColumn(ColumnName = "jiaoshixingming")]
		public string Jiaoshixingming { get; set; }

		/// <summary>
		/// Desc: 发布时间
		/// </summary>
        [SugarColumn(ColumnName = "fabushijian")]
		public DateTime? Fabushijian { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
