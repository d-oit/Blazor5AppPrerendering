using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor5AppPrerendering.Shared.Services
{
    public class PreRenderService : IPreRenderService
    {
        public bool IsPreRendering { get; private set; }

        public PreRenderService()
        {
        }

        public PreRenderService(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor.HttpContext.Response.HasStarted)
            {
                IsPreRendering = false;
            }
            else
            {
                IsPreRendering = true;
            }
        }
    }

    public interface IPreRenderService
    {
        bool IsPreRendering { get; }
    }
}
