namespace CallStatusService
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service(@"../../Resources/1_04_2016/14.txt", @"../../Resources/2_04_2016/14.txt");
            service.DifferencesBetweenFiles();
        }
    }
}
