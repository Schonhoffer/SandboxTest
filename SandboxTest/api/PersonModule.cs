using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace SandboxTest.api
{
	public class PersonModule : NancyModule
	{
		public PersonModule()
			: base("/api")
		{
			Get["/"] = parameters => HttpStatusCode.NotImplemented;
		}

	}
}