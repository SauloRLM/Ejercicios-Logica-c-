class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int result = calculator.Add(a, b);
        Console.WriteLine("Result: " + result);
        Console.ReadLine();
    }
}


 class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}