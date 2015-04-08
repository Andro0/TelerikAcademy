namespace MobilePhoneDevice
{
    using System;

    class GSMTest
    {
        /*Problem 7. GSM test
             Write a class GSMTest to test the GSM class:
             Create an array of few instances of the GSM class.
             Display the information about the GSMs in the array.
             Display the information about the static property IPhone4S. */

        private static GSM[] testGSMs = new GSM[2];

        //static void Main()
        //{
        //    GSMTest.TestPrint();   //Commented Can NOT use two Main methods
        //}

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
        }
    }
}
