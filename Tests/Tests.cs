using System;
using System.Linq;
using NUnit.Framework;
using Microsoft95Keygen;

namespace Tests
{
	[TestFixture]
	public partial class Tests
	{
		[Test]
		public void CdKeyTest()
		{
			var keys = CdGen.Keygen(100_000); // Make a ton of keys
			var valid = true;
			foreach (var key in keys.Where(key => Validate(key) == false)) // See if they're valid
				valid = false;

			Assert.True(valid);
		}
		
		[Test]
		public void OemKeyTest()
		{
			var keys = OemGen.Keygen(100_000); // Make a ton of keys
			var valid = true;
			foreach (var key in keys.Where(key => Validate(key) == false)) // See if they're valid
				valid = false;

			Assert.True(valid);
		}
	}
}