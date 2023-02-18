static void First()
{
    string a = "1";
    int b = 2;
    int c = 3;
    double d = 4;
    float e = 5;

    //fixme - should be 15 :|
    int sum = Int32.Parse(a) + b + c + (int)d + (int)e;
    Console.WriteLine(sum);
}

static void Second()
{
    string a = "1";
    int b = 2;
    int c = 3;
    double d = 4.2;
    float e = 5.3f;

    //fixme - should be 15.5 :| 
    float sum = Single.Parse(a) + b + c + d + e;
    Console.WriteLine(sum);
}
    }
}