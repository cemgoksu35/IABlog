using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogdal = blogDal;
        }


        public List<Blog> GetBlogListWithCategory()
        {
            return _blogdal.GetListWithCategory();
        }

        public Blog TGetById(int id)
        {
            return _blogdal.GetById(id);
        }

        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogdal.GetListWithCategoryByWriter(id);
        }


        public List<Blog> GetBlogById(int id)
        {
            return _blogdal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogdal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetListAll();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogdal.GetListAll(x => x.WriterId == id);
        }

        public void TAdd(Blog t)
        {
            _blogdal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogdal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogdal.Update(t);
        }
    }
}

