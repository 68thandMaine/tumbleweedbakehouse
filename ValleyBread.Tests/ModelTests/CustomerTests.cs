
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using ValleyBread.Models;

namespace ValleyBread.Tests
{
  [TestClass]
  public class CustomerTests : IDisposable
  {
    public void Dispose()
    {
      Customer.ClearAll();
    }
    public CustomerTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=Customer_Tests;";
    }
    [TestMethod]
    publi void CustomerConstructor_CreatesIntanceOfCustomer_Customer()
    {
      Customer newCustomer = new Customer("first", "last", 1, "email", "city", "state", 3, 0)
    }
  }
}
