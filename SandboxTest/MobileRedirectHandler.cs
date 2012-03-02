using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxTest
{
	public class MobileRedirectHandler : IHttpModule
	{
		private string MobileSiteURL = "/mobile";

		public void Init(HttpApplication app)
		{
			app.BeginRequest += this.OnBeginRequest;
		}

		public void Dispose() { }

		public void OnBeginRequest(object o, EventArgs args)
		{
			HttpContext context = HttpContext.Current;

			if (/* context.Request.Browser.IsMobileDevice && */
				context.Request.RawUrl.LastIndexOf(MobileSiteURL) < 0)
				context.Response.Redirect(MobileSiteURL, true);
		}
	}
}