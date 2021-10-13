// Дано 3 числа. Определите сумму чисел кратных 3.

// На входе у нас есть input с тремя числами
int[] input = new int[3] { 9, 5, 3 };
int result = 0;

// Перебираем каждое число как i в inputе
foreach (int i in input)
{
    // Число i кратно числу n, если i делится на n без остатка.
    // i % 3
    // если остаток от деления числа на 3 равен 0 суммируем его к результату
    if (i % 3 == 0) {
        result += i;
    }
}

// Пишем результат - сумму чисел, кратных 3
System.Console.Write("{0} ", result);