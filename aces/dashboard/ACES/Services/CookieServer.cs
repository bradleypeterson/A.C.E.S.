using Microsoft.AspNetCore.Http;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Services
{
    public class CookieServer
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CookieServer(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //public string Get(string key)
        //{
        //    return Request.Cookies[key];
        //}
    }
}
