namespace PhotoStudioTests;

using System.Diagnostics;
using PhotoStudio;
using Xunit;

public class ServicesTest
{
    [Fact]
    public void ServicesCreateTrue()
    {
        //Arrange
        int id = 22;
        string numService = "77";
        string nameService = "Photo";
        string quantity = "1";
        string price = "30$";
        string temp = $"{id},{numService},{nameService},{quantity},{price}";

        //Act
        var service1 = new Service(id, numService, nameService, quantity, price);

        //Assert
        Assert.Equal(service1.ToString(), temp);
    }

    [Fact]
    public void ExceptionCreateFalse()
    {
        //Arrange
        int id = 22;
        string numService = "77";
        string nameService = "Photo";
        string quantity = "1";
        string price = "30$";
        string temp = $"{id},{numService},{nameService},{quantity},{price}";

        //Act
        //Assert
        Assert.Throws<ArgumentNullException>(() => new Service(id, null!, null!, null!, null!));
    }
}