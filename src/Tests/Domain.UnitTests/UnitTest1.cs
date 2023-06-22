namespace Domain.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Youre_Not_Funny()
    {
        var you = false;

        Assert.False(you);
    }
}