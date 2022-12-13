using System;
namespace PhotoStudioTests;
using PhotoStudio;

using System.Net;
using Xunit;

public class OrdersTest
{
    [Fact]
    public void OrdersCreateTrue()
    {
        //Arrange
        string numOrder = "15";
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";
        string temp = $"{numOrder},{numClient},{fullName},{address},{email}";

        //Act
        var client1 = new Client(numClient, fullName, address, email);
        var order2 = new Order(numOrder, client1);
        //Asssert
        Assert.Equal(order2.ToString(), temp);
    }

    [Fact]
    public void ExceptionCreateFalse()
    {
        //Arrange
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";
        //Act
        var client1 = new Client(numClient, fullName, address, email);
        //Assert
        Assert.Throws<ArgumentNullException>(() => new Order(null!, client1));

    }

    [Fact]
    public void AddCreateTrue()
    {
        //Arrange
        string numOrder = "213";
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";
        string numService = "77";
        string nameService = "Photo";
        string quantity = "1";
        string price = "30$";
        //Act
        var client1 = new Client(numClient, fullName, address, email);
        var service1 = new Service(numService, nameService, quantity, price);
        var order1 = new Order(numOrder, client1);
        order1.AddService(service1);

        //Assert
        Assert.Equal(order1.service.Contains(service1), true);
    }
}

