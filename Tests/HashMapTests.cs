using DataStructures;

namespace Tests;

public class HashMapTests
{
    [Fact]
    public void Simple()
    {
        var a = new HashMap<int>();
        a.Set("a", 10);

        var value = a.Get("a");
        
        Assert.Equal(10, value);
    }

    [Fact]
    public void Collision()
    {
        var hashMap = new HashMap<int>(10);
        string key1 = "a";
        string key2 = "k";

        hashMap.Set(key1, 10);
        hashMap.Set(key2, 20);

        var value1 = hashMap.Get(key1);
        var value2 = hashMap.Get(key2);

        Assert.NotEqual(value1, value2);
    }
}