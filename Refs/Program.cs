//void ByRef (ref int x)
//{
//    x++;
//}

//int a = 100;

//ByRef(ref a);

//Console.WriteLine(a);

using Refs;
using System.Runtime.CompilerServices;

//SomeClass sc = new SomeClass();

//ref int b = ref sc.Get(1);

//b = 5000;

//Console.WriteLine(sc.Get(1));

//int c = 10;

//ref int d = ref c;

//d = 20;

//Console.WriteLine(c);

int e = 100;
int f = 66;

MyStruct ms = new MyStruct(ref e);

//if (!Unsafe.IsNullRef(ref ms.Value))
//    Console.WriteLine(ms.Value);
//else
//    Console.WriteLine("Null");

//ms.Value = f;
//ms.Value = ref f;

Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(ms.Value);
