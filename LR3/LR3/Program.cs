
using LR3.Numbers;

Number number1 = new Real(4);
Number number2 = new Real(5.5);

Console.WriteLine(number1 + number2);

Number number3 = new Integer(4);
Number number4 = new Real(5.5);

Console.WriteLine(number3 + number4);

Number number5 = new Real(5.5);
Number number6 = new Integer(4);

Console.WriteLine(number5 + number6);