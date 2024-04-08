using prakt.Ectension;

namespace prakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // string text = Console.ReadLine();
            //Console.WriteLine(text.ToCapitolize());

            
            IsEven(null);
        }
        static void IsEven(int? num)
        {
            if (num == null) { Console.WriteLine("wrong"); }
            else { Console.WriteLine(num % 2 == 0); }

            foreach (var item  in Enum.GetValues(typeof(School)))
            { Console.WriteLine(item.ToString()); }
        }
        
        

    }
}
