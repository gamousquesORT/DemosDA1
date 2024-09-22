using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToRefactorExamples;

namespace RefactoringExamplesTests;

[TestClass]
public class RefactoringTests
{
    [TestMethod]
    public void Should_Return_the_Average_Given_a_Set_Of_One_Even_Number()
    {
        List<int> numbers = new() {8};
        operations_on_numbers rf = new operations_on_numbers();
        int want = 8;
        int got = rf.magic_function(numbers);
        Assert.AreEqual(want, got);
    } 
    
    [TestMethod]
    public void Should_Return_The_Average_Given_a_Set_Of_Two_Even_Numbers()
    {
        List<int> numbers = new() { 2, 6 };
        operations_on_numbers rf = new operations_on_numbers();
        int want = 4;
        int got = rf.magic_function(numbers);
        Assert.AreEqual(want, got);
    }
    
    [TestMethod]
    public void Should_Return_The_Even_Number_Given_A_SetWith_One_Even_And_One_Odd_Number()
    {
        List<int> numbers = new() { 2, 7 };
        operations_on_numbers rf = new operations_on_numbers();
        int want = 2;
        int got = rf.magic_function(numbers);
        Assert.AreEqual(want, got);
    }
    
    [TestMethod]
    public void Should_Return_The_Even_Number_Given_A_SetWith_More_Than_One_Even_And_One_Odd_Number()
    {
        List<int> numbers = new() {0, 2, 7 };
        operations_on_numbers rf = new operations_on_numbers();
        int want = 1;
        int got = rf.magic_function(numbers);
        Assert.AreEqual(want, got);
    }
 
    [TestMethod]
    public void Should_Return_TheAverage_Given_An_Odd_SetOf_Even_Numbers_Including_Zero()
    {
        List<int> numbers = new() {0, 2, 6, 8, 12, 24, 28 };
        operations_on_numbers rf = new operations_on_numbers();
        int want = Convert.ToInt32(numbers.Average());
        int got = rf.magic_function(numbers);
        Assert.AreEqual(want, got);
    } 
    
    [TestMethod]
    public void Should_Return_TheAverage_Given_ASetOf_Even_Numbers_Containing_a_Cero()
    {
        List<int> numbers = new() {0, 6, 8, 12, 24, 28 };
        operations_on_numbers rf = new operations_on_numbers();
        int want = Convert.ToInt32(numbers.Average());
        int got = rf.magic_function(numbers);
        Assert.AreEqual(want, got);
    }  
    
    [TestMethod]
    //refactorear por el tipo de excpción
    [ExpectedException(typeof(Exception))]
    public void Should_Throw_ArgumentExcep_Given_An_Empty_Set()
    {
        List<int> numbers = new();
        operations_on_numbers rf = new operations_on_numbers();
        rf.magic_function(numbers);

    } 
    
    [TestMethod]
    //refactorear por el tipo de excpción
    [ExpectedException(typeof(Exception))]
    public void Should_Return_Message_Given_ASet_of_Odd_Numbers()
    {
        List<int> numbers = new() { 1, 5, 7, 35 };
        operations_on_numbers rf = new operations_on_numbers();
        rf.magic_function(numbers);
    }  

 
}