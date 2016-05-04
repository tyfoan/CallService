namespace CallStatusService
{
    class Program
    {
        static void Main(string[] args)
        {
            Service a = new Service(@"C:\Users\Александр\Documents\visual studio 2015\Projects\CallService\CallService\history task\1_04_2016\14.txt", 
                @"C:\Users\Александр\Documents\visual studio 2015\Projects\CallService\CallService\history task\2_04_2016\14.txt");
            a.Method();
        }
    }
}
