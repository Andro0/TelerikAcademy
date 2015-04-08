namespace MobilePhoneDevice
{
    using System;

    /*Problem 8. Calls
           Create a class Call to hold a call performed through a GSM.
           It should contain date, time, dialled phone number and duration (in seconds).*/
    class Call
    {
        DateTime timeOfCall;
        string dialedNumber;
        int duration;

        public Call(string dialedNumber, int duration)
        {
            this.timeOfCall = DateTime.Now;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        public DateTime TimeOfCall
        {
            get
            {
                return this.timeOfCall;
            }
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
        }





    }
}
