# For my Documentation of C# Learning

### Variables

> How to declare a variable

1. Numeric Types

```
    int age = 25;    // whole numbers
    long distance = 100000;  // very large whole numbers
    float price = 19.99f;    // decimal num ( low precision )
    double pi = 3.123;   // decimal num ( high precision )
    decimal salary = 599.50m;    // money / financial ( very precise)
```

2. Text Types

```
    string name = "John";   //text
    char grade = 'A';   // single character
```

3. Boolean Type

```
    bool isOnline = True;   //True/False Vaule
```

4. Var ( Implicit Type)
   > C# can automatically detect the type

```
    var city = "Manila";    //string
    var count = 10;     //int
```

> var still has a type, it's just inferred by the computer

5. Object ( Most General Type )

```
    object data = "Hello"; // can story any type
    data =123;
    data = true;
```

> Useful whe nthe type may chagne or is unknown

> Use Const when the value never changes:

```
    const double PI = 3.14;
```

### If Statement

1. If + Else

```
int age = 15;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}

```

2.  If - Else if - Else

```
int grade = 85;

if (grade >= 90)
{
    Console.WriteLine("A");
}
else if (grade >= 80)
{
    Console.WriteLine("B");
}
else if (grade >= 70)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("Failed");
}
```

3. Ternary Operator ( Short Version)

```
int age = 20;
string result = (age >= 18) ? "Adult" : "Minor";
Console.WriteLine(result);

```
