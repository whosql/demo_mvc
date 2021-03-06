using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDAL _categorydal;

        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categorydal = categoryDal;
        }

        public void CategoryAdd(Category p)
        {
            _categorydal.Insert(p);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        public void CategoryAdd()
        {
            throw new NotImplementedException();
        }

        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryStatus == false || p.CategoryName.Length <= 2)
        //    {
        //        // hata mesajı 
        //    }
        //    else
        //    {
        //        _categorydal.Insert(p);
        //    }
        //}
    }
}
