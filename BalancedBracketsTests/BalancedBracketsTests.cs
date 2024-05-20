namespace BalancedBracketsTests;
using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.


    //Positives - return true

    //Looking for empty -returns true
    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(true, true);
    }

    //Equal number of brackets -returns true
    [TestMethod]
    public void OnlyBracketsReturnsTrue() 
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
    }

    //Looking for brackets around a string -returns true
    [TestMethod]
    public void BracketsAroundStringReturnsTrue()
    {
        //Arrange
        string testStr = "[LaunchCode]";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }

    //Looking for string with brackets inside part of string -returns true
    [TestMethod]
    public void BracketsAroundPartOfStringReturnsTrue()
    {
        //Arrange
        string testStr = "Launch[Code]";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }
   
    //Looking for a string starting with brackets -returns true
    [TestMethod]
    public void BracketsAtBeginningOfStringReturnsTrue()
    {
        //Arrange
        string testStr = "[]LaunchCode";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }




    //Negatives -return false


    //Looking for brackets facing wrong direction -return false - gives a false zero
    [TestMethod]
    public void BracketsInStringFacingWrongDirectionReturnsFalse()
    {
        //Arrange
        string testStr = "][";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }

    //Looking for one bracket at beginning of string but no closing bracket -return false
    [TestMethod]
    public void OneBracketAtStartButMissingClosingBracketReturnsFalse()
    {
        //Arrange
        string testStr = "[LaunchCode";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }

    //Looking for a string with brackets inside of part of the string facing the wrong direction -return false
    [TestMethod]
    public void BracketsInPartOfStringFacingWrongDirectionReturnsFalse()
    {
        //Arrange
        string testStr = "Launch]Code[";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }

    //Looking for only opening bracket -return false
    [TestMethod]
    public void OneOpeningBracketInStringReturnsFalse()
    {
        //Arrange
        string testStr = "[";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsFalse(actual);
    }



    //Other 

    
    //Looking for curly brace and brackets in string -return true -checking if brackets are balanced
    [TestMethod]
    public void CurlyBracePlusBracketsInStringReturnsTrue()
    {
        //Arrange
        string testStr = "{[]";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }

    //Looking for brackets inside of curly braces, checking that curly braces have no effect -returns True
    [TestMethod]
    public void BracketsInsideCurlyBracesInsideStringReturnsTrue()
    {
        //Arrange
        string testStr = "{[]}";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);
    }

    //Looking for multiple opening brackets and then the text and then multiple closing brackets -returns True
    [TestMethod]
    public void OpeningBracketsPlusTextPlusClosingBracketsReturnsTrue()
    {
        //Arrange
        string testStr = "[[[[LaunchCode]]]]";
        //Act
        bool actual = BalancedBrackets.HasBalancedBrackets(testStr);
        //Assert
        Assert.IsTrue(actual);

}
}
