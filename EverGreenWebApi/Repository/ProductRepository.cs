using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EverGreenWebApi.DBHelper;
using EverGreenWebApi.Interfaces;
using EverGreenWebApi.Models;

namespace EverGreenWebApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAllProductByCategory(int categoryid)
        {
            using (pos_androidEntities context = new pos_androidEntities())
            {
                //string path = "http://103.233.79.234/Data/EverGreen_Android/ProductPictures/";

                var result = (from p in context.productmasters                             
                              where p.CategoryId == categoryid
                              orderby p.ProductName
                              select new ProductModel()
                              {
                                  ProductId = p.ProductId,
                                  ProductName = p.ProductName,
                                  CategoryId = (int)p.CategoryId,
                                  UnitPrice = (decimal)p.UnitPrice,
                                  GST = (decimal)p.GST,
                                  Discount = (decimal)p.Discount,
                                  TaxType = p.TaxType,
                                  UOM = p.UOM,                                 
                                  SweetsReset = p.SweetsReset,
                                  ProductDetails = p.ProductDetails,
                                  Lock = p.Lock,
                                  //StoreId = j4.StoreId
                              }).ToList();

                //    var data = result.Select(p => new ProductModel()
                //    {
                //        ProductId = p.ProductId,
                //        ProductName = p.ProductName,
                //        CategoryId = (int)p.CategoryId,
                //        UnitPrice = (decimal)p.UnitPrice,
                //        GST = (decimal)p.GST,
                //        Discount = (decimal)p.Discount,
                //        TaxType = p.TaxType,
                //        UOM = p.UOM,
                //        HSN = p.HSN,                    
                //        SweetsReset = p.SweetsReset,
                //        ProductDetails = p.ProductDetails,
                //        Lock = p.Lock,

                //        //ProductPicturesUrl = path + p.ProductId + "ProductPictures.jpg",
                //}).ToList();
                return result;
            }
        }

        //public IEnumerable<ProductModel> GetAllProductList()
        //{
        //    using (evergreen_androidEntities context = new evergreen_androidEntities())
        //    {
        //        //string path = "http://103.233.79.234/Data/EverGreen_Android/ProductPictures/";

        //        var result = context.productmasters.OrderBy(p => p.ProductName);
        //        var data = result.Select(p => new ProductModel()
        //        {
        //            ProductId = p.ProductId,
        //            ProductName = p.ProductName,
        //            CategoryId = (int)p.CategoryId,
        //            UnitPrice = (decimal)p.UnitPrice,
        //            GST = (decimal)p.GST,
        //            Discount = (decimal)p.Discount,
        //            TaxType = p.TaxType,
        //            UOM = p.UOM,
        //            HSN = p.HSN,
        //            SweetsReset = p.SweetsReset,
        //            ProductDetails = p.ProductDetails,
        //            Lock = p.Lock,
        //            //ProductPicturesUrl = path + p.ProductId + "ProductPictures.jpg",
        //        }).ToList();
        //        return data;
        //    }
        //}
    }
}