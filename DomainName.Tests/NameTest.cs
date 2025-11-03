using System.Runtime.InteropServices;

namespace DomainPrimitives.Tests;

public class LastNameTests
{
    [Theory]
    [InlineData("AA")]
    [InlineData("åÅæÆøØAAAAAAAAAaaaaa")]
    public void Firstname_is_valid(string? input)
    {
        var result = new DomainPrimitives.FirstName(input);
        Assert.NotNull(result);
    }

    [Theory]
    [InlineData("AA")]
    [InlineData("åÅæÆøØAAAAAAAAAaaaaa")]
    [InlineData("A")]
    public void Lastname_is_valid(string? input)
    {
        var result = new DomainPrimitives.LastName(input);
        Assert.NotNull(result);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("AAAAAAAAAAAAAAAAAAAAA")]
    [InlineData("A")]
    [InlineData("!!")]
    [InlineData("@@")]
    [InlineData("##")]
    [InlineData("$$")]
    [InlineData("%%")]
    [InlineData("&&")]
    [InlineData("//")]
    [InlineData("((")]
    [InlineData("))")]
    [InlineData("{{")]
    [InlineData("}}")]
    [InlineData("[[")]
    [InlineData("]]")]
    [InlineData("??")]
    [InlineData("££")]
    [InlineData("¤¤")]
    [InlineData("**")]
    [InlineData("++")]
    [InlineData("==")]
    [InlineData("^^")]
    [InlineData("~~")]
    [InlineData("--")]
    [InlineData("\\")]
    [InlineData("1234567890")]
    public void LastName_Invalid_NullOrWhitespace_Throws(string? input)
    {
        Assert.Throws<ArgumentException>(() => new DomainPrimitives.LastName(input));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("AAAAAAAAAAAAAAAAAAAAA")]
    [InlineData("A")]
    [InlineData("!!")]
    [InlineData("@@")]
    [InlineData("##")]
    [InlineData("$$")]
    [InlineData("%%")]
    [InlineData("&&")]
    [InlineData("//")]
    [InlineData("((")]
    [InlineData("))")]
    [InlineData("{{")]
    [InlineData("}}")]
    [InlineData("[[")]
    [InlineData("]]")]
    [InlineData("??")]
    [InlineData("££")]
    [InlineData("¤¤")]
    [InlineData("**")]
    [InlineData("++")]
    [InlineData("==")]
    [InlineData("^^")]
    [InlineData("~~")]
    [InlineData("--")]
    [InlineData("\\")]
    [InlineData("1234567890")]
    public void FirstName_Invalid_NullOrWhitespace_Throws(string? input)
    {
        Assert.Throws<ArgumentException>(() => new DomainPrimitives.FirstName(input));
    }
}
