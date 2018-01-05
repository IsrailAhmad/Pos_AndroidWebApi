using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EverGreenWebApi.Models;

namespace EverGreenWebApi.Interfaces
{
    public interface IProductRepository:IDisposable
    {
        IEnumerable<ProductModel> GetAllProductByCategory(int categoryid);
        //IEnumerable<ProductModel> GetAllProductList();
    }
}