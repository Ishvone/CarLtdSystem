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
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders Orders = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Orders.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Orders.DateAdded, TestData);
        }

        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders Orders = new clsOrders();
            //create some test data to assign to the property
            String TestData = "#9999";
            //assign data to the property
            Orders.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Orders.Status, TestData);

        }
    }

    class clsOrders
    {
    }
}
