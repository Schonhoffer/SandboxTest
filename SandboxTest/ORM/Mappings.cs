using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;

namespace SandboxTest.ORM
{
	public class AffiliationMap : ClassMap<Person>
	{
		public AffiliationMap()
		{
			Id(x => x.PersonId);
			Map(x => x.Name);
		}
	}
}