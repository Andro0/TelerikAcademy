namespace MobilePhoneDevice
{
    using System;


    class Battery
    {
        /*Problem 1. Define class */
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryTypes? type; //Problem 3.

        /*Problem 2. Constructors */
        public Battery()
            : this(null)
        {
        }

        public Battery(string model)
            : this(model, null)
        {
        }

        public Battery(string model, int? hoursIdle)
            : this(model, hoursIdle, null)
        {
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk)
            : this(model, hoursIdle, hoursTalk, null)
        {
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryTypes? type) //Problem 3.
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        /*Problem 5. Properties */
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

        public int? HoursIdle 
        { get
            {
                return this.hoursIdle;
            }
            set 
            {
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryTypes? Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }

        


    }
}
