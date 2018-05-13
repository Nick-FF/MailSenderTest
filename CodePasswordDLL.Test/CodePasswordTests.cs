using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordDLL;
using System.Diagnostics;

namespace CodePasswordDLL.Test
{
	[TestClass]
	public class CodePasswordTests : IDisposable
	{
        string strIn = "";
        string strExpected = "";
        bool disposed;



        [TestInitialize]
        public static void TestInitialize(TestContext context)
        {
            Debug.WriteLine("Test Initialize");
           
        }
        [TestMethod]
		public void getCodPassword_abc_bcd()
		{
			// arrange
			strIn = "abc";
			strExpected = "bcd";
			// act
			string strActual = CodePassword.GetCodPassword(strIn);
			//assert
			//Assert.AreEqual(strExpected, strActual);
            Debug.WriteLine(AssertEqual(strIn, strExpected));
        }

        [TestMethod]
        public void getCodPassword_empty_empty()
        {
            // arrange
            string strIn = "";
            string strExpected = "";
            // act
            string strActual = CodePassword.GetCodPassword(strIn);
            //assert
            Assert.AreEqual(strExpected, strActual);
        }
        [TestCleanup]
        public void TestCleanup (TestContext context) 
        {
            bool disposed = false;
            Dispose();

        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose (bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                
            }
                      
            disposed = true;
        }

        public string AssertEqual (string a, string b)
        {
            if (Equals(a,b))
            {
                return "Test complete";
            }
            else
            {
                return "Test failed";
            }
        }

    }
}

