using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xiezn.Core.Common.Helpers;
using Xiezn.Core.Models;
using Xiezn.Core.Models.DbModel;


namespace Xiezn.Core.Business.Services
{
    public class XueshengchengjiService : BaseService<XueshengchengjiDbModel>
    {
        private readonly long _uid;
        private readonly string _role;
        private readonly string _tablename;

        public XueshengchengjiService()
        {
            try
            {
                if (CacheHelper.TokenModel != null)
                {
                    _uid = CacheHelper.TokenModel.Uid;
                    _role = CacheHelper.TokenModel.Role;
                    _tablename = CacheHelper.TokenModel.Tablename;
                }
            }
            catch
            {
                _uid = 0;
                _role = "游客";
            }
        }






        public PageModel<XueshengchengjiDbModel> GetPageList(int page, int limit, string sort, string order, List<IConditionalModel> conModels)
        {
            PageModel pageModel = new PageModel() { PageIndex = page, PageSize = limit };

            int totalNumber = 0;
            int totalPage = 0;
            string[] sortFields = sort.Split(',');
            string[] orderFields = order.Split(',');
            string mysort = "";
            for (int i = 0; i < sortFields.Length; i++)
            {
                if (i == sortFields.Length - 1)
                {
                    mysort += sortFields[i] + " " + orderFields[i];
                }
                else
                {
                    mysort += sortFields[i] + " " + orderFields[i] + ",";

                }

            }
            List<XueshengchengjiDbModel> ts = Db.Queryable<XueshengchengjiDbModel>().Where(conModels).OrderBy(mysort).ToPageList(page, limit, ref totalNumber, ref totalPage);


            PageModel<XueshengchengjiDbModel> t = new PageModel<XueshengchengjiDbModel>()
            {
                Code = ResponseCodeEnum.Success,
                Data = new Page<XueshengchengjiDbModel>()
                {
                    Total = totalNumber,
                    PageSize = limit,
                    TotalPage = totalPage,
                    CurrPage = page,
                    List = ts
                }
            };

            return t;
        }







        public dynamic SectionStat_chengji(string where)
        {
            string sql = @"
                SELECT '不合格' as chengji,case when t.不合格 is null then 0 else t.不合格 end total
                from
                (select
                sum(case when chengji <= 59 then 1 else 0 end) as 不合格,                sum(case when chengji >= 60 and chengji <= 79 then 1 else 0 end) as 合格,                sum(case when chengji >= 80 then 1 else 0 end) as 优秀                from xueshengchengji " + where +@"
                ) t
                union all
                SELECT '合格' as chengji,case when t.合格 is null then 0 else t.合格 end total
                from
                (select
                sum(case when chengji <= 59 then 1 else 0 end) as 不合格,                sum(case when chengji >= 60 and chengji <= 79 then 1 else 0 end) as 合格,                sum(case when chengji >= 80 then 1 else 0 end) as 优秀                from xueshengchengji " + where +@"
                ) t
                union all
                SELECT '优秀' as chengji,case when t.优秀 is null then 0 else t.优秀 end total
                from
                (select
                sum(case when chengji <= 59 then 1 else 0 end) as 不合格,                sum(case when chengji >= 60 and chengji <= 79 then 1 else 0 end) as 合格,                sum(case when chengji >= 80 then 1 else 0 end) as 优秀                from xueshengchengji " + where +@"
                ) t
            ";
            dynamic result = Db.SqlQueryable<dynamic>(sql).ToList();

            return result;
        }

    }
}
