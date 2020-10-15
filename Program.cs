using System;

namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rico!");

            int[] integerVal = {-40,10,-35,6,2,-25,20,15,30};
            sort(integerVal);
            Console.WriteLine(string.Join(" | ", integerVal));
        }


        public static void sort<T>(T[] array) where T: IComparable{

            Sort(array, 0, array.Length-1);
        }

        // Sort methods checks to see if the array have two elements by comparing the lower and upper element variables, which will then initiate the Partition method to partion them recursively for the two subarrays which are the lower and upper.

        private static T[] Sort<T>(T[] array, int lower, int upper) where T:IComparable{
            //  checking to see if my lower element is less than the upper, if the case, then we partion and sort them

            if(lower < upper){

                int p = Partition(array, lower, upper);
                //  Here we are sorting
                Sort(array, lower, p);
                Sort(array, upper, p + 1);
            }

            return array;
        }


        private static int Partition<T>(T[] array, int lower, int upper) where T: IComparable{

            //  i will go ahead and set up my two elements and then my pivot point

            int i = lower;
            int j = upper;
            T pivot = array[lower];

            do{
                while(array[i].CompareTo(pivot)< 0){i++;}
                while(array[j].CompareTo(pivot) > 0) {j--;}

                Swap(array, i, j);
            }
            while(i <= j);
            
            return j;

            


        }


        private static void Swap<T>(T[] array, int first, int second){

            T temp = array[first];
            array[first]= array[second];
            array[second]= temp;
        }















    }
}
