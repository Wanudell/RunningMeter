namespace RunningMeter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDataTrue = false;

            do
            {
                try
                {
                    Console.WriteLine("Bir adım uzunluğunuzu 'CM' cinsinden giriniz.");
                    int x = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        try
                        {
                            Console.WriteLine("Bir dakika içerisinde kaç adım attığınızın verisini giriniz.");
                            int y = Convert.ToInt32(Console.ReadLine());
                            isDataTrue = true;
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Koşu sürenizi saat ve dakika olarak ayrı ayrı belirtiniz.");  
                                    var z = Convert.ToInt32(Console.ReadLine());
                                    var q = Convert.ToInt32(Console.ReadLine());
                                    isDataTrue = true;

                                    RunBabyRun(z, q, y, x);


                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("Girdiğiniz değer yanlış formattadır. Lütfen doğru değeri giriniz.");
                                    isDataTrue = false;
                                }
                            } while (!isDataTrue);
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Girdiğiniz değer yanlış formattadır. Lütfen doğru değeri giriniz.");
                            isDataTrue = false;
                        }
                    } while (!isDataTrue);
                }
                catch (Exception)
                {

                    Console.WriteLine("Girdiğiniz değer yanlış formattadır. Lütfen doğru değeri giriniz.");
                    isDataTrue = false;
                }
                Console.WriteLine("Tekrar denemek ister misiniz ? Evet veya E yazınız.");
                var a = Console.ReadLine().ToLower().ToString();

                if(a == "evet" && a == "e")
                {
                    isDataTrue = false;
                }
                else isDataTrue = true;
                
            } while (!isDataTrue);
        }


        public static void RunBabyRun(int a, int d, double b, double c)
        {
            int min = a * 60 + d;
            double hourStep = min * b;
            double meterDone = hourStep * c/100;
            Console.WriteLine($"Toplam koşu yaptığınız dakika : {min}");
            Console.WriteLine($"Toplam koşu yaptığınız adım sayısı : {hourStep}");
            Console.WriteLine($"Toplam koşu yaptığınız metre : {meterDone}");
        }
        
    }
}