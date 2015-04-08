namespace MobilePhoneDevice
{
    using System;

    class Display
    {
        /*Problem 1. Define class */
        private decimal? size;
        private int? colors;

        /*Problem 2. Constructors */
        public Display()
            : this(null)
        {
        }

        public Display(decimal? size)
            : this(size, null)
        {
        }

        public Display(decimal? size, int? colors)
        {
            this.size = size;
            this.colors = colors;
        }

        /*Problem 5. Properties */
        public decimal? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid size: " + value);
                }
                this.size = value;
            }
        }

        public int? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid number of colors: " + value);
                }
                this.colors = value;
            }
        }


    }
}
