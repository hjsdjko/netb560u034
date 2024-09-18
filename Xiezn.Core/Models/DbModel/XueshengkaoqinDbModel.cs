using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 学生考勤
    /// </summary>
    [SugarTable("xueshengkaoqin")]
	public class XueshengkaoqinDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 考勤编号
		/// </summary>
		[SugarColumn(ColumnName = "kaoqinbianhao")]
		public string Kaoqinbianhao { get; set; }

		/// <summary>
		/// Desc: 课程名称
		/// </summary>
		[SugarColumn(ColumnName = "kechengmingcheng")]
		public string Kechengmingcheng { get; set; }

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
		/// Desc: 出勤次数
		/// </summary>
        [SugarColumn(ColumnName = "chuqincishu")]
		public int? Chuqincishu { get; set; } = 0;

		/// <summary>
		/// Desc: 请假次数
		/// </summary>
        [SugarColumn(ColumnName = "qingjiacishu")]
		public int? Qingjiacishu { get; set; } = 0;

		/// <summary>
		/// Desc: 迟到次数
		/// </summary>
        [SugarColumn(ColumnName = "chidaocishu")]
		public int? Chidaocishu { get; set; } = 0;

		/// <summary>
		/// Desc: 早退次数
		/// </summary>
        [SugarColumn(ColumnName = "zaotuicishu")]
		public int? Zaotuicishu { get; set; } = 0;

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
		/// Desc: 登记时间
		/// </summary>
        [SugarColumn(ColumnName = "dengjishijian")]
		public DateTime? Dengjishijian { get; set; }

		/// <summary>
		/// Desc: 考勤内容
		/// </summary>
		[SugarColumn(ColumnName = "kaoqinneirong")]
		public string Kaoqinneirong { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}
