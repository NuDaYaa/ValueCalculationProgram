Console.WriteLine("Введите x");
var x = Convert.ToDouble(Console.ReadLine());
    var y = Math.PI * Math.Sin(1) / 8;
var sum = 0.0;
for (int n = 1; n <= 50; n++)
{
    sum += n * Math.Sin(2 * n);
}
    Console.WriteLine($" Аналитическая функция\t=\t{{{Math.Round(y, 3)}\") ");
Console.WriteLine($" расчётная функция\t=\t{{{Math.Round(sum, 3)}\") ");

    if (Math.Abs(sum - y) < 0.1)
        {
            Console.WriteLine("Расчёт произведён верно");
        }
    else
        {
            Console.WriteLine("Расчёт произведён не верно");
        }
Console.ReadKey();