namespace PhotoStudioTests;

using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using PhotoStudio;

public class ClientsTest
{
    [Fact]
    public void ClientsCreateTrue()
    {
        //Arrange
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";
        string temp = $"{numClient},{fullName},{address},{email}";


        //Act
        var client1 = new Client(numClient, fullName, address, email);
        //Assert
        Assert.Equal(client1.ToString(), temp);
    }

    [Fact]
    public void ExceptionCreateFalse()
    {
        //Arrange
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";
        string temp = $"{numClient},{fullName},{address},{email}";

        //Act
        //Assert
        Assert.Throws<ArgumentNullException>(() => new Client(numClient, null!, null!, null!));
    }

    [Fact]
    public void EqualsObjTrue()
    {
        //Arrange
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";

        //Act
        var client1 = new Client(numClient, fullName, address, email);

        //Assert
        Assert.True(client1.Equals(client1));

    }
    [Fact]
    public void EqualsObjFalse()
    {
        //Arrange
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";

        //Act
        var client1 = new Client(numClient, fullName, address, email);
        var client2 = new Client(numClient, fullName, address, email);

        //Assert
        Assert.False(client1.Equals(client2));
    }
}