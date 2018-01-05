using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EverGreenWebApi.DBHelper;
using EverGreenWebApi.Interfaces;
using EverGreenWebApi.Models;

namespace EverGreenWebApi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<CategoryModel> GetAllCategoryList()
        //{
        //    using (pos_androidEntities context = new pos_androidEntities())
        //    {
        //        // string path = "http://103.233.79.234/Data/EverGreen_Android/CategoryPictures/";

        //        var result = context.categorymasters.OrderBy(c => c.CategoryName);
        //        var data = result.Select(c => new CategoryModel()
        //        {
        //            CategoryId = c.CategoryId,
        //            CategoryName = c.CategoryName,
        //            //CategoryDescription = c.CategoryDescription,
        //            //StoreId = (int)c.StoreId,
        //            //CategoryPictures = path + c.CategoryId + "CategoryPictures.jpg",
        //        }).ToList();
        //        return data;
        //    }
        //}

        public IEnumerable<CategoryModel> GetAllCategoryByMenuId(int storeid)
        {
            using (pos_androidEntities context = new pos_androidEntities())
            {
                //string path = "http://103.233.79.234/Data/EverGreen_Android/CategoryPictures/";

                var result = context.categorymasters.Where(c => c.StoreId == storeid).OrderBy(c => c.CategoryName);
                var data = result.Select(c => new CategoryModel()
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    CategoryDescription = c.CategoryDescription,
                    StoreId = (int)c.StoreId,
                    //CategoryPictures = path + c.CategoryId + "CategoryPictures.jpg",
                }).ToList();
                return data;
            }
        }
    }
}