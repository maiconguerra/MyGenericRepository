using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var factory = new DataAccess.DefaultFactory();
			var cartBO = new Business.Cart(factory);
			cartBO.SaveOrder(new Business.Entity.Order(), new System.Collections.Generic.List<Business.Entity.Product>());
		}
	}
}
