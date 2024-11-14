namespace tip_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tip calculator");
            Console.WriteLine("please enter bill amount before tax");

            double billbeforetax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter tip percentage");
            double tipercentage = Convert.ToDouble(Console.ReadLine());

            double tipAmount = billbeforetax * tipercentage / 100;

            double grandtotal = billbeforetax + tipAmount;

            Console.WriteLine("the tip amount is " + tipAmount);
            Console.WriteLine($"the grand total is {grandtotal}");

        }
    }
    }

