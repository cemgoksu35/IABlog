using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerdal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerdal = writerDal;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerdal.GetListAll(x => x.WriterId == id);
        }

        public void TAdd(Writer t)
        {
            _writerdal.Insert(t);
        }


        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
           return _writerdal.GetById(id);
        }

        public void TUpdate(Writer t)
        {
            _writerdal.Update(t);
        }


     
    }
}

