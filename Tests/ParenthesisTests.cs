using DataStructures;

namespace Tests;


public class ParenthesisValidatorTests
{
    [Fact]
    public void AllParenthesesAreValid()
    {
        var validator = new Parenthesis();
        string input = "()[]{}";
        bool result = validator.IsValid(input);
        Assert.True(result);
    }

    [Fact]
    public void WrongParenthesis()
    {
        var validator = new Parenthesis();
        string input = "(]";
        bool result = validator.IsValid(input);
        Assert.False(result);
    }

    [Fact]
    public void EmptyString()
    {
        var validator = new Parenthesis();
        string input = "";
        bool result = validator.IsValid(input);
        Assert.False(result);
    }

    [Fact]
    public void IncompleteParenthesis()
    {
        var validator = new Parenthesis();
        string input = "(";
        bool result = validator.IsValid(input);
        Assert.False(result);
    }

}