namespace HesapMakinesi
{

    class program
    {
        static void Main(string[] args)
        {
            Hesaplayici hs = new Hesaplayici();

            string num1, num2, islem;
        start:
            Console.WriteLine("Enter the number");
            num1 = Console.ReadLine();
            Console.WriteLine("Enter the number");
            num2 = Console.ReadLine();

            if (num1 == null || num2 == null || !hs.RakamMi(num1) || !hs.RakamMi(num2))
            {
                Console.WriteLine("False value");
                goto start;
            }

            int sayi1 = Convert.ToInt32(num1);
            int sayi2 = Convert.ToInt32(num2);

        islem:
            Console.WriteLine("Choose to aplication: is addition enter the 1    is subtraction enter the 2     is multiplication enter the 3      is  division enter the 4");
            islem = Console.ReadLine();
            Console.Clear();

            switch (islem)
            {

                case "1":
                    Console.Clear();
                    Console.WriteLine("Result " + hs.Topla(sayi1, sayi2));
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Result " + hs.Cikar(sayi1, sayi2));
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Result " + hs.Carp(sayi1, sayi2));
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Result " + hs.Bol(sayi1, sayi2));
                    break;

                default:
                    Console.WriteLine("False value");
                    goto islem;
            }

        }
    }
}





