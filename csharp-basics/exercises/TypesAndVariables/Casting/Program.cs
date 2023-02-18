using System;

static void First()
{
    string a = "1";
    int b = 2;
    int c = 3;
    double d = 4;
    float e = 5;

    int sum = int.Parse(a) + b + c + (int)d + (int)e;
    Console.WriteLine(sum);
}

static void Second()
{
    string a = "1";
    int b = 2;
    int c = 3;
    double d = 4.2;
    float e = 5.3f;

    double sum = double.Parse(a) + b + c + d + e;
    Console.WriteLine(sum);
}