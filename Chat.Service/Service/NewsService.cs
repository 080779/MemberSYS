using Chat.DTO.DTO;
using Chat.IService.Interface;
using Chat.Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chat.IService.Interface.INewsService;

namespace Chat.Service.Service
{
    public class NewsService : INewsService
    {
        #region 添加新闻公告
        /// <summary>
        /// 添加新闻公告
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="Title"></param>
        /// <param name="Content"></param>

        /// <returns></returns>
        public long Add(string Title,int dropNewType, string Context,DateTime Time)
        {
            using (MyDbContext dbcontext = new MyDbContext())
            {
                NewsEntity newsModel = new NewsEntity();

                newsModel.NewsTitle = Title;
                newsModel.NewsContent = Context;
                newsModel.NewType = dropNewType;
                newsModel.PublishTime = Time;
               
                dbcontext.News.Add(newsModel);
                dbcontext.SaveChanges();
                return newsModel.ID;
            }

        }
        #endregion
        #region 获取列表
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public List<NewsDTO> GetList()
        {
            using (MyDbContext dbcontext = new MyDbContext())
            {
                CommonService<NewsEntity> csr = new CommonService<NewsEntity>(dbcontext);
                return csr.GetAll().ToList().Select(p => ToDTO(p)).ToList();
            }
        }
        #endregion 

        public NewsPageResult GetPageList(int PageIndex, int PageSize)
        {
            using (MyDbContext dbcontext = new MyDbContext())
            {
                CommonService<NewsEntity> csr = new CommonService<NewsEntity>(dbcontext);
                NewsPageResult PageResult = new NewsPageResult();
                var NewsQuery = csr.GetAll();
                PageResult.TotalCount = NewsQuery.LongCount();
                PageResult.News = NewsQuery.OrderByDescending(p => p.CreateTime).Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList().Select(p => ToDTO(p)).ToArray();
                return PageResult;
            }
        }
        public NewsDTO ToDTO(NewsEntity msg)
        {
            NewsDTO news = new NewsDTO();
            news.ID = msg.ID;
            news.NewsTitle = msg.NewsTitle;
            news.PublishTime = msg.PublishTime;
            news.NewType = (int)msg.NewType;
          
            return news;
        }
        /// <summary>
        /// 根据ID查询用户
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public NewsDTO GetModel(long Id)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CommonService<NewsEntity> cs = new CommonService<NewsEntity>(dbc);
                NewsEntity r = cs.GetById(Id);
                if (r != null)
                {
                    return new NewsDTO
                    {
                        NewsTitle = r.NewsTitle,
                        PublishTime = r.PublishTime,
                        NewType = r.NewType == null ? 0:(int)r.NewType,
                        NewsType = r.NewsType,
                        Publisher = string.IsNullOrWhiteSpace(r.Publisher) ? "" : r.Publisher,
                        ImageURL = r.ImageURL,
                        Classify = r.Classify,
                        Tags = r.Tags,
                        Click = r.Click == null ? 0 : (int)r.Click,
                        New01 = r.New01 == null ? 0:(int)r.New01,
                        New02 = r.New02 == null ? 0:(int)r.New02,
                        New03 = r.New03 == null ? 0 :(decimal)r.New03,
                        New04 = r.New04 == null ? 0 :(decimal)r.New04,
                        New05 = string.IsNullOrWhiteSpace(r.New05) ? "" : r.New05,
                        New06 = string.IsNullOrWhiteSpace(r.New06) ? "" : r.New06,
                        CreateTime = r.CreateTime,
                        NewsContent = r.NewsContent,
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        public bool Update(NewsDTO hh)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
              
                CommonService<NewsEntity> acs = new CommonService<NewsEntity>(dbc);
                NewsEntity news = acs.GetAll().SingleOrDefault(a => a.ID == hh.ID);
                news.NewsTitle = hh.NewsTitle;
                news.NewsContent = hh.NewsContent;
                news.PublishTime = hh.PublishTime;
                news.NewType = hh.NewType;
                
                dbc.SaveChanges();
                return true;
            }
        }

    }
}
