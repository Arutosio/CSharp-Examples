//TUPLE EXSAMPLE
var tuple = (1, "one");
Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
var tuple2 = (num: 2, text: "two");
Console.WriteLine($"{tuple2.num}, {tuple2.text}");

(int num, string text) tuple3 = (3, "trce");
Console.WriteLine($"{tuple3.num}, {tuple3.text}");

public (int, bool, string) getTupla(string allura)
{
    if (allura == "allura")
    {
        return (1, true, "giustu");
    }
    else
    {
        return (0, false, "sbaghiatu");
    }
}

var (num, eVeru, text) = getTupla("allura");
Console.WriteLine($"{num}, {eVeru}, {text}");