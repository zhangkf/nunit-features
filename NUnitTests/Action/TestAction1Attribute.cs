using System;
using NUnit.Framework;

namespace NUnitTests
{
	public class TestAction1Attribute : Attribute, ITestAction
	{
		public TestAction1Attribute ()
		{
		}

		public void BeforeTest (TestDetails testDetails)
		{
			Console.WriteLine ("Test Action before test...{0}, {1}, {2}", testDetails.Fixture, testDetails.Method.Name,testDetails.IsSuite);
		}

		public void AfterTest (TestDetails testDetails)
		{
			Console.WriteLine ("Test Action after test..."+ testDetails.FullName);
		}

		public ActionTargets Targets {
			get {
				return ActionTargets.Default;
			}
		}
	}
}

