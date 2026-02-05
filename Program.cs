namespace Car_Reg_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charge = 0;
            Console.Write("Enter your car registration: ");
            string carReg = Console.ReadLine();
            while (carReg.Length > 8)
            {
                string displayMessge = carReg + " is not valid";
                Console.Write(displayMessge);
                carReg = Console.ReadLine();
            }
            Console.Write("Enter your stay in hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            if (hours < 2)
            {
                charge = 0;
            }
            else
            {
                charge = hours * 2 + 2;
            }
            Console.WriteLine(charge);

            // Test both changes with the following test data
            // A369 WNV1
            // BV03 NXD, 5 
            // CS73 CSP, 1
            // Show your test evidence in the Readme
        }
    }
}
