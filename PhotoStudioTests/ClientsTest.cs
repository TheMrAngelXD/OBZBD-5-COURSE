namespace PhotoStudioTests;

using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using PhotoStudio;

public class ClientsTest
{
    [Fact]
    public void ClientsCreateTrue()
    {
        //Arrange
        int id = 17;
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";
        string temp = $"{id},{numClient},{fullName},{address},{email}";


        //Act
        var client1 = new Client(id, numClient, fullName, address, email);
        //Assert
        Assert.Equal(client1.ToString(), temp);
    }

    [Fact]
    public void ExceptionCreateFalse()
    {
        //Arrange
        int id = 17;
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";
        string temp = $"{id},{numClient},{fullName},{address},{email}";

        //Act
        //Assert
        Assert.Throws<ArgumentNullException>(() => new Client(id, numClient, null!, null!, null!));
    }

    [Fact]
    public void EqualsObjTrue()
    {
        //Arrange
        int id = 17;
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";

        //Act
        var client1 = new Client(id, numClient, fullName, address, email);

        //Assert
        Assert.True(client1.Equals(client1));

    }
    [Fact]
    public void EqualsObjFalse()
    {
        //Arrange
        int id1 = 17;
        int id2 = 2;
        int numClient = 12;
        string fullName = "Chizhov Ivan Vasilievich";
        string address = "RUT MIIT";
        string email = "chizhik@mail.ru";

        //Act
        var client1 = new Client(id1, numClient, fullName, address, email);
        var client2 = new Client(id2, numClient, fullName, address, email);

        //Assert
        Assert.False(client1.Equals(client2));
    }
}

//    public struct TestResult
//    {

//        public bool IsSuccess { get; set; }
//        public string ErrorMessage { get; set; }

//        public static TestResult CreateSuccess()
//        {
//            return new TestResult()
//            {
//                IsSuccess = true
//            };
//        }

//        public static TestResult CreateFailure(string message)
//        {
//            return new TestResult()
//            {
//                IsSuccess = false,
//                ErrorMessage = message
//            };
//        }
//        private static TestResult SafeCall(string functionName,
//                                           Func<TestResult> test)
//        {

//            try
//            {
//                return test();
//            }
//            catch (System.Exception ex)
//            {

//                string message =
//                    string.Format("{0} threw {1}: {2}",
//                                  functionName,
//                                  ex.GetType().Name,
//                                  ex.Message);

//                return TestResult.CreateFailure(message);

//            }

//        }
        
//        private static TestResult
//            TestGetHashCodeOnEqualObjects<T>(T obj1, T obj2)
//        {
//            return SafeCall("GetHashCode", () =>
//            {
//                if (obj1.GetHashCode() != obj2.GetHashCode())
//                    return TestResult.CreateFailure(
//                        "GetHashCode of equal objects " +
//                        "returned different values.");
//                return TestResult.CreateSuccess();
//            });
//        }
//    }
//}
