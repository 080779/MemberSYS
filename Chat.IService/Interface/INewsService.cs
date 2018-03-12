using Chat.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.IService.Interface
{
    public interface INewsService : IServiceSupport
    {
        //增加公告
        long Add(string Title, int dropNewType, string Context, DateTime Time);

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        NewsPageResult GetPageList(int PageIndex, int PageSize);
        ///获取id
        NewsDTO GetModel(long Id);
        //更新
        bool Update(NewsDTO hh);

    }
    public class NewsPageResult
    {
        public long TotalCount { get; set; }
        public NewsDTO[] News { get; set; }
    }
}
