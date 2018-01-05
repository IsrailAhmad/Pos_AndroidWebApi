using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EverGreenWebApi.Interfaces;
using EverGreenWebApi.Models;
using EverGreenWebApi.Repository;

namespace EverGreenWebApi.Controllers
{
    public class ProductController : ApiController
    {
        static readonly IProductRepository _repository = new ProductRepository();

        [HttpPost]
        public HttpResponseMessage GetAllProductByCategory(ProductModel model)
        {
            ResponseStatus response = new ResponseStatus();
            try
            {
                if (model.CategoryId >= 0 )
                {
                    var data = _repository.GetAllProductByCategory(model.CategoryId);
                    if (data.Count() > 0)
                    {
                        response.isSuccess = true;
                        response.serverResponseTime = System.DateTime.Now;
                        return Request.CreateResponse(HttpStatusCode.OK, new { data, response });
                    }
                    else
                    {
                        response.isSuccess = false;
                        response.serverResponseTime = System.DateTime.Now;
                        return Request.CreateResponse(HttpStatusCode.BadRequest, new { response });
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Please Check Category Id !");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Something Worng !", ex);
            }
        }

        //[HttpGet]
        //public HttpResponseMessage GetAllProductList()
        //{
        //    ResponseStatus response = new ResponseStatus();
        //    try
        //    {
        //        var data = _repository.GetAllProductList();
        //        if (data.Count() > 0)
        //        {
        //            //response.isSuccess = true;
        //            //response.serverResponseTime = System.DateTime.Now;
        //            return Request.CreateResponse(HttpStatusCode.OK, new { data, response });
        //        }
        //        else
        //        {
        //            //response.isSuccess = false;
        //            //response.serverResponseTime = System.DateTime.Now;
        //            return Request.CreateResponse(HttpStatusCode.BadRequest, new { response });
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Something Worng !", ex);
        //    }
        //}
    }
}
