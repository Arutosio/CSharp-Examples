//Expression Lambda
//(parameter) => expression

//Statement Lambda
//(parameter) => { <statements> };

//Example 1
Func<string> sayHello = () => "Hello!";
Console.WriteLine(sayHello()); // Hello!

//Example 2
Func<string, string> sayHello2 = (string name) => $"Hello {name}!";
// OR Func<string, string> sayHello2 = name => $"Hello {name}!"; 
Console.WriteLine(sayHello2("Arutosio")); // Hello Arutosio!

//Example 3
Action hello3 = () => Console.WriteLine("Hello!");
hello3(); // Hello!

//Example 4
Action<string> hello4 = (name) => Console.WriteLine($"Hello, {name}!");
hello4("Arutosio"); // Hello, Arutosio!

//Example 5
Action<int, int> couple = (v1, v2) =>
{
    int sum = v1 + v2;
    Console.WriteLine($"{v1} + {v2} = {sum}");
};
couple(2, 3); // 2 + 3 = 5


//Example 1 Expression-bodied Members
static string heyName(string name) => $"Hey, {name}!";

//Example 2 Expression-bodied Members
public class Person
{
    private string name;

    public string Name
    {
        get => this.name.ToUpper();
        set => this.name = value;
    }

    public Person(string name) => this.name = name;
}
Person p = new Person("Ahegao");
Console.WriteLine($"Hello {p.Name}!");
