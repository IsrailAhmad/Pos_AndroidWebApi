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
    public class CategoryController : ApiController
    {
        static readonly ICategoryRepository _repository = new CategoryRepository();

        [HttpPost]
        public HttpResponseMessage GetAllCategoryByMenuId(CategoryModel model)
        {
            ResponseStatus response = new ResponseStatus();
            try
            {
                if (model.StoreId > 0)
                {
                    var data = _repository.GetAllCategoryByMenuId(model.StoreId);
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
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Please Check Locality Id !");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Something Worng !", ex);
            }
        }

        //[HttpGet]
        //public HttpResponseMessage GetAllCategoryList()
        //{
        //    ResponseStatus response = new ResponseStatus();
        //    try
        //    {

        //        var data = _repository.GetAllCategoryList();
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
