using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayindexer
{
    internal class ListInt
    {
        private int[] array;


        public int Length
        {
            get
            {
                return array.Length;
            }
        }


        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public ListInt()
        {
            array = new int[0];
        }
        public ListInt(int length)
        {
            array = new int[length];
        }

        public ListInt(params int[] nums)
        {
            array = nums;
        }


        public void Add(int num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = num;

        }
        public void AddRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = nums[i];
            }

        }

        public bool Contains(int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        public void Sum()
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum+=array[i];
               
               
              
            }
            Console.WriteLine(sum);
        }
        public void Remove(int num)
        {
            int[] newarray = new int[array.Length - 1];

            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != num)
                {
                    newarray[j] = array[i];
                    j++;


                }
                newarray = array;
               
            }
            return;
        }
        public void RemoveRange(params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Remove(nums[i]);
            }
        }
        public override string ToString()
        {
            return string.Join(",", array);
        }
    }
}
