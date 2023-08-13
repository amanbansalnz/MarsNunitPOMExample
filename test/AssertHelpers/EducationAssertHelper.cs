
using System;
using NUnit.Framework;

namespace test.AssertHelpers
{
	public class EducationAssertHelper
	{

		public static void assertAddEducationSuccessMessage(String expected, String actual) {

			Assert.AreEqual(expected, actual, "succes message is correct for add education");

        }


	}
}

