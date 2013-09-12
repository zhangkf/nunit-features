using System;
using NUnit.Framework;

namespace NUnitTests
{
	[TestFixture()]
	public class NUnitTest
	{
		[Test()]
		[TestAction2Attribute]
		[TestAction1Attribute]
		public void TestMethod ()
		{
			Console.WriteLine ("this is a test.");
		}
	}
}

