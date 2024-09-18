using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 课程信息
    /// </summary>
    [SugarTable("kechengxinxi")]
	public class KechengxinxiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 课程代码
		/// </summary>
		[SugarColumn(ColumnName = "kechengdaima")]
		public string Kechengdaima { get; set; }

		/// <summary>
		/// Desc: 课程名称
		/// </summary>
		[SugarColumn(ColumnName = "kechengmingcheng")]
		public string Kechengmingcheng { get; set; }

		/// <summary>
		/// Desc: 课程封面
		/// </summary>
		[SugarColumn(ColumnName = "kechengfengmian")]
		public string Kechengfengmian { get; set; }

		/// <summary>
		/// Desc: 课程类型
		/// </summary>
		[SugarColumn(ColumnName = "kechengleixing")]
		public string Kechengleixing { get; set; }

		/// <summary>
		/// Desc: 授课班级
		/// </summary>
		[SugarColumn(ColumnName = "shoukebanji")]
		public string Shoukebanji { get; set; }

		/// <summary>
		/// Desc: 上课时间
		/// </summary>
        [SugarColumn(ColumnName = "shangkeshijian")]
		public DateTime? Shangkeshijian { get; set; }

		/// <summary>
		/// Desc: 课程描述
		/// </summary>
		[SugarColumn(ColumnName = "kechengmiaoshu")]
		public string Kechengmiaoshu { get; set; }

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
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
