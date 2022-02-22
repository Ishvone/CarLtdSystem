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

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders Orders = new clsOrders();
            //create some test data to assign to the property
            int TestData = "#00001";
            //assign data to the property
            Orders.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(CustomerID.Status, TestData);
        }

        [TestMethod]
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

        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to create
            clsOrders Orders = new clsOrders();
            //create some test data to assign to the property
            int TestData = "#14453";
            //assign data to the property
            Orders.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Orders.ProductID, TestData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders Orders = new clsOrders();
            //create some test data to assign to the property
            String TestData = "SHIPPED";
            //assign data to the property
            Orders.Status = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Orders.Status, TestData);

        }
    }
}
