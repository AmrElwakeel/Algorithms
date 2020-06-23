using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(SearchingAlgorithms.BinarySerach(arr, 12));

            //int[] arr = { 3,9,5,9,4,6,2,8};
            //SelectionSort(arr);

            //BubbleSort(arr1);

            //InsertionSort(arr1);
            //Recursive(arr,0);

            //SortingAlgorthmis.SortMerge(arr, 0,arr.Length-1);

            //SortingAlgorthmis.SortQuick(arr, 0, arr.Length - 1);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }


        public static void StrategyPattern()
        {
            SwimOne swimOne = new SwimOne();
            Person p = new Person(swimOne);
        }
    }


    #region StrategyPattern
    class Person
    {
        private readonly SwimBehaver swimBehaver;

        public Person(SwimBehaver swimBehaver)
        {
            this.swimBehaver = swimBehaver;
        }
        void wake() { }
    }
    interface SwimBehaver
    {
        void swim();
    }
    class SwimOne : SwimBehaver
    {
        public void swim()
        {
            throw new NotImplementedException();
        }
    }
    class SwimTwo : SwimBehaver
    {
        public void swim()
        {
            throw new NotImplementedException();
        }
    } 
    #endregion





}
