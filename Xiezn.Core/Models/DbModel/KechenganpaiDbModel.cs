using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 课程安排
    /// </summary>
    [SugarTable("kechenganpai")]
	public class KechenganpaiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 安排编号
		/// </summary>
		[SugarColumn(ColumnName = "anpaibianhao")]
		public string Anpaibianhao { get; set; }

		/// <summary>
		/// Desc: 课程名称
		/// </summary>
		[SugarColumn(ColumnName = "kechengmingcheng")]
		public string Kechengmingcheng { get; set; }

		/// <summary>
		/// Desc: 课程类型
		/// </summary>
		[SugarColumn(ColumnName = "kechengleixing")]
		public string Kechengleixing { get; set; }

		/// <summary>
		/// Desc: 工号
		/// </summary>
		[SugarColumn(ColumnName = "gonghao")]
		public string Gonghao { get; set; }

		/// <summary>
		/// Desc: 授课教师
		/// </summary>
		[SugarColumn(ColumnName = "jiaoshixingming")]
		public string Jiaoshixingming { get; set; }

		/// <summary>
		/// Desc: 上课时间
		/// </summary>
		[SugarColumn(ColumnName = "shangkeshijian")]
		public string Shangkeshijian { get; set; }

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
		/// Desc: 安排时间
		/// </summary>
        [SugarColumn(ColumnName = "anpaishijian")]
		public DateTime? Anpaishijian { get; set; }

		/// <summary>
		/// Desc: 安排内容
		/// </summary>
		[SugarColumn(ColumnName = "anpaineirong")]
		public string Anpaineirong { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
