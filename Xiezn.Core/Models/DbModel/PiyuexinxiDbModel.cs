using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 批阅信息
    /// </summary>
    [SugarTable("piyuexinxi")]
	public class PiyuexinxiDbModel
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
		/// Desc: 作业文件
		/// </summary>
		[SugarColumn(ColumnName = "zuoyewenjian")]
		public string Zuoyewenjian { get; set; }

		/// <summary>
		/// Desc: 提交时间
		/// </summary>
		[SugarColumn(ColumnName = "tijiaoshijian")]
		public string Tijiaoshijian { get; set; }

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
		/// Desc: 批阅时间
		/// </summary>
        [SugarColumn(ColumnName = "piyueshijian")]
		public DateTime? Piyueshijian { get; set; }

		/// <summary>
		/// Desc: 评分
		/// </summary>
        [SugarColumn(ColumnName = "pingfen")]
		public double? Pingfen { get; set; } = 0;

		/// <summary>
		/// Desc: 批阅内容
		/// </summary>
		[SugarColumn(ColumnName = "piyueneirong")]
		public string Piyueneirong { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
