namespace MobilePhoneDevice
{
    using System;

    /*Problem 12. Call history test
        Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        Create an instance of the GSM class.
        Add few calls.
        Display the information about the calls.
        Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        Remove the longest call from the history and calculate the total price again.
        Finally clear the call history and print it.*/

    class GSMCallHistoryTest
    {
        private static GSM[] testGSMs = new GSM[2];

        static void Main()
        {
            TestPrint();
        }

        public static void TestPrint()
        {
            testGSMs[0] = new GSM("Desire S",
                                   "HTC",
                                   555M,
                                   "Pesho",
                                   new Battery("Best Battery",
                                       100,
                                       6,
                                       BatteryTypes.NiCd),
                                   new Display(4.2m, 15000000));

            testGSMs[1] = new GSM("3310",
                                  "Nokia",
                                  150M,
                                  "Gosho",
                                  new Battery("H223",
                                      130,
                                      4,
                                      BatteryTypes.LiIon),
                                  new Display(3M));

            foreach (GSM gsm in testGSMs)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4SToString());

            testGSMs[0].AddCall("0888888888", 60);
            testGSMs[0].AddCall("0899999999", 60);
            testGSMs[0].AddCall("0877777777", 90);

            testGSMs[0].ViewCalls();
            Console.WriteLine("Total price = {0:C}", testGSMs[0].CalculatePrice(0.37M));

            testGSMs[0].RemoveCall("0888888888");
            testGSMs[0].ViewCalls();
            Console.WriteLine("Total price = {0:C}", testGSMs[0].CalculatePrice(0.37M));

            testGSMs[0].ClearHistory();
            testGSMs[0].ViewCalls();
            Console.WriteLine("Total price = {0:C}", testGSMs[0].CalculatePrice(0.37M));
        }
    }
}
