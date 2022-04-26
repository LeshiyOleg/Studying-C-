/*
Нахождение максимума из девяти чисел
*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 1983;
int c1 = 39;
int a2 = 3376;
int b2 = 23;
int c2 = 2091;
int a3 = 13;
int b3 = 333;
int c3 = 33;

/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int Maxresult = Max(max1, max2, max3);
*/
/*
Можно и так, но лучше как ниже - так наглядней
int Maxresult = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
*/

int Maxresult = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(Maxresult);