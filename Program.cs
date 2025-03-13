namespace thr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => DoWork("luong 1", 2000));
            Thread t2 = new Thread(() => DoWork("luong 2", 4000));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();


            Console.WriteLine("ket thuc!!");


        }

        static void DoWork(string name, int delay)
        {
            Console.WriteLine($"{name} dang chay ...");
            Thread.Sleep(delay);
            Console.WriteLine($"{name} da hoan thanh");
        }




    }
}