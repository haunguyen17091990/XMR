﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchWeb.Common
{
    public class WebHelpers
    {
        private static IHttpContextAccessor _httpContextAccessor;

        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public static HttpContext HttpContext
        {
            get { return _httpContextAccessor.HttpContext; }
        }

        public static string GetRemoteIP
        {
            get { return HttpContext.Connection.RemoteIpAddress.ToString(); }
        }

        public static string GetUserAgent
        {
            get { return HttpContext.Request.Headers["User-Agent"].ToString(); }
        }

        public static string GetScheme
        {
            get { return HttpContext.Request.Scheme; }
        }
    }
}
