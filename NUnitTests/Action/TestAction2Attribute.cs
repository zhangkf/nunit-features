using System;
using NUnit.Framework;

namespace NUnitTests
{
	public class TestAction2Attribute : TestActionAttribute
	{
		public TestAction2Attribute ()
		{
		}

		public override void BeforeTest (TestDetails testDetails)
		{
			Console.WriteLine ("Test Action inheritance... {0}, {1}, {2}", testDetails.FullName, testDetails.Fixture, testDetails.Method.Name);
		}

		public override void AfterTest (TestDetails testDetails)
		{
			Console.WriteLine("Test Action inheritance... ");
		}

		public override ActionTargets Targets {
			get {
				return ActionTargets.Default;
			}
		}
	}
}

