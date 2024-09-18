using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 学生作业
    /// </summary>
    [SugarTable("xueshengzuoye")]
	public class XueshengzuoyeDbModel
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
		/// Desc: 发布时间
		/// </summary>
		[SugarColumn(ColumnName = "fabushijian")]
		public string Fabushijian { get; set; }

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
		public DateTime? Tijiaoshijian { get; set; }

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
		/// Desc: 批阅状态
		/// </summary>
		[SugarColumn(ColumnName = "piyuezhuangtai")]
		public string Piyuezhuangtai { get; set; }

		/// <summary>
		/// Desc: 提交备注
		/// </summary>
		[SugarColumn(ColumnName = "tijiaobeizhu")]
		public string Tijiaobeizhu { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
