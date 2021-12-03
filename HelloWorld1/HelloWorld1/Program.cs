// See https://aka.ms/new-console-template for more information
byte number = 1;
int count = 10;
float total = 20.95f;
char ch = 'A';
string name = "Zhibek";
bool isWorking = true;
var s = "f";

Console.WriteLine("Hello, World!");
Console.WriteLine(number);
Console.WriteLine(count);

Console.WriteLine("{0}", byte.MaxValue);


byte b = 1;
int i = b;
// no data loss
Console.WriteLine(i);

int j = 1000;
byte a = (byte)i;
// cast, expicit conversion, u are aware of data loss
// data types should be compatible
Console.WriteLine(a);

try
{
    var num = "2";
    byte k = Convert.ToByte(num);
    Console.WriteLine(k);
}
catch (Exception)
{
    throw;
}

a = 2;
b = 3;
var c = 2;
Console.WriteLine((float)a/b);

Console.WriteLine(a + b*c);