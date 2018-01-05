using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EverGreenWebApi.Models;

namespace EverGreenWebApi.Interfaces
{
    public interface ICategoryRepository:IDisposable
    {
        IEnumerable<CategoryModel> GetAllCategoryByMenuId(int storeid);
        //IEnumerable<CategoryModel> GetAllCategoryList();
    }
}