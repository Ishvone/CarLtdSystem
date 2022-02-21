using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CarLtd_Testing
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders Orders = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(Orders);
        }
    }

    class clsOrders
    {
    }
}
