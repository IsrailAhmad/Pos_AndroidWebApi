using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverGreenWebApi.Models
{
    public class LocalitiesModel
    {
        public int LocalityId { get; set; }
        public string LocalityName { get; set; }
        public int CityId { get; set; }
        public string ImageUrl { get; set; }
        public HttpPostedFileBase file { get; set; }
    }
}