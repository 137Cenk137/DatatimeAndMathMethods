internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);


        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());

        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());





        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(2));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(2));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(0));
        Console.WriteLine(DateTime.Now.AddTicks(12));

        Console.WriteLine(DateTime.Now.ToString("dd")); // gün stringini getirir 25 
        Console.WriteLine(DateTime.Now.ToString("ddd"));// üc karakter olarak getirir
        
        Console.WriteLine(DateTime.Now.ToString("M"));//January 25
        Console.WriteLine(DateTime.Now.ToString("MM"));//01
        Console.WriteLine(DateTime.Now.ToString("MMM"));//Jan

        Console.WriteLine(DateTime.Now.ToString("MMMM"));//January

        Console.WriteLine(DateTime.Now.ToString("yyyy"));
        Console.WriteLine(DateTime.Now.ToString("yy"));




        Console.WriteLine(Math.Abs(-25));//25 mutlak
        Console.WriteLine(Math.Sin(MathF.PI/2));
        Console.WriteLine(Math.Sin(90));
        Console.WriteLine(Math.Cos(90));

        Console.WriteLine(Math.Tan(0));

        Console.WriteLine(Math.Ceiling(23.3));
        Console.WriteLine(Math.Round(22.3));// 0.5 mantigi
        Console.WriteLine(Math.Round(22.7));
        Console.WriteLine(Math.Floor(22.7));


        Console.WriteLine(Math.Max(1,2));
        Console.WriteLine(Math.Min(1,10));


    Console.WriteLine(Math.Pow(3, 4));
    Console.WriteLine(Math.Sqrt(16));
    Console.WriteLine(Math.Log(29));// e tabanına göre yapar
    Console.WriteLine(Math.Exp(2)); //e üzeri 2 yi verir
    Console.WriteLine(Math.Log10(10));
     

    }
}