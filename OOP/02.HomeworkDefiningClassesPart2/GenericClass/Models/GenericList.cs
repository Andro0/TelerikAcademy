using System;
using System.Linq;
using System.Text;

namespace GenericClass.Models
{
    /*Problem 5. Generic class
        Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
        Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
        Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
        Check all input parameters to avoid accessing elements at invalid positions.*/
    public class GenericList<T> where T: IComparable<T>
    {
        private int nextIndex = 0;
        private T[] data;

        public GenericList(int initialCapacity)
        {
            this.data = new T[initialCapacity];
        }

        public void Add(T element)
        {
            if (this.nextIndex == this.data.Length)
            {
                this.AutoGrow();
            }

            this.data[nextIndex] = element;
            this.nextIndex++;
        }

        public T this[int index]
        {
            get
            {
                if (index > this.nextIndex - 1)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.data[index];
            }
            private set { this.data[index] = value; }
        }

        public void Remove(int index)
        {
            for (int i = index; i < this.nextIndex && i < this.data.Length - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.nextIndex--;
            this.data[nextIndex] = default(T);
        }

        public void Insert(int index, T element)
        {
            if (this.nextIndex == this.data.Length)
            {
                this.AutoGrow();
            }

            for (int i = this.nextIndex; i >= index && i > 0; i--)
            {
                this.data[i] = this.data[i - 1];
            }

            this.data[index] = element;
            this.nextIndex++;
        }

        public void Clear()
        {
            this.data = new T[this.data.Length];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.nextIndex; i++)
            {
                sb.Append(this.data[i]);
                if (i < this.nextIndex - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }
              
        /*Problem 6. Auto-grow
            Implement auto-grow functionality: when the internal array is full, 
            create a new array of double size and move all elements to it.*/
        private void AutoGrow()
        {
            var newData = new T[this.data.Length * 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        /*Problem 7. Min and Max
          Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
          You may need to add a generic constraints for the type T.*/
        public T Min()
        {
            if (this.nextIndex == 0)
            {
                throw new ArgumentException("There are no elements in the GenericList");
            }

            T min = this.data[0];
            foreach (T item in this.data)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public T Max()
        {

            if (this.nextIndex == 0)
            {
                throw new ArgumentException("There are no elements in the GenericList");
            }

            T max = this.data[0];
            foreach (T item in this.data)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

       

    }
}
