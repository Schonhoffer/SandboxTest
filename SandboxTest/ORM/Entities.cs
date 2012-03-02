using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxTest.ORM
{
	public class Person
	{
		public virtual int PersonId { get; private set; }
		public virtual string Name { get; set; }
	}
}