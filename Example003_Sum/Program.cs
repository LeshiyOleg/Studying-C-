// Нахождение суммы двух чисел - чтобы не удалять первые строки - сделал из них коммент
//int numberA = 31;
//int numberB = 51;
//int result = numberA + numberB;
//Console.WriteLine(result);

int numberA = new Random().Next(1,10); //выбирается рандомное число от 1 (включ) до 10 (не вкючит)
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int resultSum = numberA + numberB;
Console.WriteLine(resultSum);