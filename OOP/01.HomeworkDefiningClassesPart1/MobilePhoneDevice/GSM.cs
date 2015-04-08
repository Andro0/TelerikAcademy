namespace MobilePhoneDevice
{
    //If you do not see all information on the Console, increase console buffer size from console properties!!!

    using System;
    using System.Collections.Generic;
    using System.Text;

    class GSM
    {
        /*Problem 1. Define class
             Define a class that holds information about a mobile phone device:
             model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk)
             and display characteristics (size and number of colors).
             Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
        */
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        List<Call> calls = new List<Call>();

        /*Problem 6. Static field
             Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.*/
        static private GSM iPhone4S;

        /*Problem 2. Constructors
            Define several constructors for the defined classes that take different sets of 
            arguments (the full information for the class or part of it).
            Assume that model and manufacturer are mandatory (the others are optional). 
            All unknown data fill with null.  */

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.CallHistory = new List<Call>();
        }

        /*Problem 6. Static field */
        static GSM()
        {
            iPhone4S = new GSM("iPhone 4S",
                "Apple",
                399.00m,
                "Bob",
                new Battery("Non-removable Li-Po 1432 mAh battery (5.3 Wh)",
                    200,
                    8,
                    BatteryTypes.LiIon),
                    new Display(4.5m, 16000000));
        }

        /*Problem 6. Static field */
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        /*Problem 5. Properties
             Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
             Ensure all fields hold correct data at any given time.*/
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid manufacturer: " + value);
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price: " + value);
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid name: " + value);
                this.owner = value;
            }
        }

        /*Problem 9. Call history
            Add a property CallHistory in the GSM class to hold a list of the performed calls.
            Try to use the system class List<Call>.*/
        private List<Call> CallHistory { get; set; }

        /*Problem 7. GSM test*/
        public static string IPhone4SToString()
        {
            StringBuilder printInfo = new StringBuilder();
            printInfo.Append(String.Format("Manufacture: {0}\n", iPhone4S.manufacturer));
            printInfo.Append(String.Format("Model: {0}\n", iPhone4S.model));
            printInfo.Append(iPhone4S.price == null ? String.Format("Price: {0}\n") : String.Format("Price: {0}\n", iPhone4S.price));
            printInfo.Append(iPhone4S.owner == null ? String.Format("Owner: {0}\n") : String.Format("Owner: {0}\n", iPhone4S.owner));

            printInfo.Append("\nBattery\n");
            printInfo.Append(String.Format("{0,2}{1,-10} - {2}\n", "-", "Model", iPhone4S.battery.Model));
            printInfo.Append(iPhone4S.battery.HoursIdle == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursIdle", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursIdle", iPhone4S.battery.HoursIdle));
            printInfo.Append(iPhone4S.battery.HoursTalk == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursTalk", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursTalk", iPhone4S.battery.HoursTalk));
            printInfo.Append(iPhone4S.battery.Type == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "Type", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "Type", iPhone4S.battery.Type));

            printInfo.Append("\nDisplay\n");
            printInfo.Append(String.Format("{0,2}{1,-10} - {2}\"\n", "-", "Size", iPhone4S.display.Size));
            printInfo.Append(iPhone4S.display.Colors == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "Colors", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "Colors", iPhone4S.display.Colors));


            return printInfo.ToString();
        }



        /*Problem 4. ToString
                Add a method in the GSM class for displaying all information about it.
                Try to override ToString().*/

        public override string ToString()
        {
            StringBuilder printInfo = new StringBuilder();
            printInfo.Append("--------------------------\n");
            printInfo.Append(String.Format("{0, -13} - {1}\n", "Manufacture", this.manufacturer));
            printInfo.Append(String.Format("{0, -13} - {1}\n", "Model", this.model));
            printInfo.Append(this.price == null ? String.Format("{0, -13} - unknown\n", "Price") : String.Format("{0, -13} - {1}\n", "Price", this.price));
            printInfo.Append(this.owner == null ? String.Format("{0, -13} - unknown\n", "Owner") : String.Format("{0, -13} - {1}\n", "Owner", this.owner));

            printInfo.Append("\nBattery\n");
            printInfo.Append(String.Format("{0,2}{1,-10} - {2}\n", "-", "Model", this.battery.Model));
            printInfo.Append(this.battery.HoursIdle == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursIdle", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursIdle", this.battery.HoursIdle));
            printInfo.Append(this.battery.HoursTalk == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursTalk", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "HoursTalk", this.battery.HoursTalk));
            printInfo.Append(this.battery.Type == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "Type", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "Type", this.battery.Type));

            printInfo.Append("\nDisplay\n");
            printInfo.Append(String.Format("{0,2}{1,-10} - {2}\"\n", "-", "Size", this.display.Size));
            printInfo.Append(this.display.Colors == null ? String.Format("{0,2}{1,-10} - {2}\n", "-", "Colors", "unknown") : String.Format("{0,2}{1,-10} - {2}\n", "-", "Colors", this.display.Colors));

            printInfo.Append("--------------------------\n");
            return printInfo.ToString();
        }

        /*Problem 10. Add/Delete calls
               Add methods in the GSM class for adding and deleting calls from the calls history.
               Add a method to clear the call history.*/
        public void AddCall(string dailedNumber, int duration)
        {
            Call newCall = new Call(dailedNumber, duration);
            this.calls.Add(newCall);
        }

        public void RemoveCall(string numberToDel)
        {
            int removedCallsCount;

            if (this.calls.Count > 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No calls in history");
                return;
            }

            removedCallsCount = this.calls.RemoveAll(
                delegate(Call call)
                {
                    return call.DialedNumber == numberToDel;
                });

            if (removedCallsCount > 0)
            {
                Console.WriteLine("{0} calls removed\n", removedCallsCount);
            }
            else
            {
                Console.WriteLine("Call not found");
            }
        }

        public void ClearHistory()
        {
            this.calls.Clear();

            Console.WriteLine("\nAll calls cleared\n");
        }

        public void ViewCalls()
        {
            if (calls.Count > 0)
            {
                Console.WriteLine("---------------- Calls List ------------------");
                Console.WriteLine("{0,-10}{1,-13} | {2,-8} | {3}", "Date", "Time", "Number", "Duration");
                foreach (var call in this.calls)
                {
                    Console.WriteLine("{0,-23} | {1,-8} | {2}", call.TimeOfCall, call.DialedNumber, call.Duration);
                }
                Console.WriteLine("----------------------------------------------");
            }
            else
            {
                Console.WriteLine("\nNo calls\n");
            }
        }

        /*Problem 11. Call price
            Add a method that calculates the total price of the calls in the call history.
            Assume the price per minute is fixed and is provided as a parameter.*/
        public decimal CalculatePrice(decimal costPerMinute)
        {
            int totalSecondCount = 0;

            foreach (var call in calls)
            {
                totalSecondCount += call.Duration;
            }

            return (totalSecondCount / 60) * costPerMinute;
        }

    }
}
