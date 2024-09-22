using Domain;

namespace UserTest;

[TestClass]
public class UserTests
{
    [TestMethod]
    [DataRow("gastón", "GASTÓN")]
    [DataRow("MARIA", "MARIA")]
    public void GivenAValidName_ReturnsNameUpperCase(string givenName, string expectedName)
    {
        User u = new User();
        u.Name = givenName;
        Assert.AreEqual(expectedName, u.Name);
    }
    
    [TestMethod]
    public void GivenValidNumber_ReturnsGivenNumber()
    {
        User u = new User();
        u.Number = 5198;
        int expectedNumber = 5198;
                
        Assert.AreEqual(expectedNumber, u.Number);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    [DataRow(-1)]
    [DataRow(10001)]
    public void GivenInvalidNumber_ThrowsArgumentException(int number)
    {
        User u = new User();
        u.Number = number;
    }
}