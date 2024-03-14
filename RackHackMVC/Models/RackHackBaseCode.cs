
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace RackHackMVC.Models
{
    public class RackHack
    {
        public static int[] EightBallRackHack()
        {

            int[] middleNumbers = { 1, 2, 3, 4, 5, 6, 7, /* 8 */ 9, 10, 11, 12, 13, 14, 15 };


            middleNumbers = ShuffleArray(middleNumbers);


            int[] result = new int[15] { middleNumbers[0], middleNumbers[1], middleNumbers[2], middleNumbers[3],
                8, middleNumbers[4], middleNumbers[5], middleNumbers[6], middleNumbers[7],
                middleNumbers[8], middleNumbers[9], middleNumbers[10], middleNumbers[11],
                middleNumbers[12], middleNumbers[13], };


            return result;

        }




        public static int[] EightBallRackHackDifferentWings()
        {

            int[] middleNumbers = { 1, 2, 3, 4, 5, 6, 7,/* 8 */ 9, 10, 11, 12, 13, 14, 15 };


            middleNumbers = ShuffleArray(middleNumbers);


            while (middleNumbers[9] < 8 && middleNumbers[13] < 8 ||
                middleNumbers[9] > 8 && middleNumbers[13] > 8)
            {
                middleNumbers = ShuffleArray(middleNumbers);
            }


            int[] result = new int[15] { middleNumbers[0], middleNumbers[1], middleNumbers[2], middleNumbers[3],
                8, middleNumbers[4], middleNumbers[5], middleNumbers[6], middleNumbers[7], middleNumbers[8],
                middleNumbers[9], middleNumbers[10], middleNumbers[11], middleNumbers[12], middleNumbers[13], };


            return result;

        }




        public static int[] NineBallRackHack()
        {
            // Initialize an array with numbers from 2 to 8
            int[] middleNumbers = { 2, 3, 4, 5, 6, 7, 8 };

            //int[] middleNumbers = Enumerable.Range(2, 7).Distinct().ToArray();


            middleNumbers = ShuffleArray(middleNumbers);



            int[] result = new int[9] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 9,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], middleNumbers[6] };


            //Console.WriteLine("Nine ball: " + string.Join(", ", result.Select(num => num.ToString())));

            //return new int[] { };


            return result;
        }



        //This is for 9-ball tournaments that mandate the 2 ball be at the back of the rack
        public static int[] NineBallRackHack2AtBack()
        {
            int[] middleNumbers = { 3, 4, 5, 6, 7, 8 };

            //int[] middleNumbers = Enumerable.Range(3, 6).Distinct().ToArray();


            middleNumbers = ShuffleArray(middleNumbers);


            int[] result = new int[9] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 9,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], 2 };


            //Console.WriteLine("Nine ball 2 at back: " + string.Join(", ", result.Select(num => num.ToString())));


            //return new int[] { };


            return result;
        }



        public static int[] NineBallRackHack2ProhibitedFromBack()
        {

            // Initialize an array with numbers from 2 to 8
            int[] middleNumbers = { 2, 3, 4, 5, 6, 7, 8 };


            //int[] middleNumbers = Enumerable.Range(2, 7).Distinct().ToArray();


            // Shuffle the middle numbers using ballRandomizer function
            middleNumbers = ShuffleArray(middleNumbers);


            // Check if the 7th element is 2, if so, reshuffle until it's not 2
            while (middleNumbers[6] == 2)
            {
                middleNumbers = ShuffleArray(middleNumbers);
            }


            // Initialize the result array with 1 at the zeroth index and 9 at the fourth index
            int[] result = new int[9] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 9,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], middleNumbers[6] };



            //Console.WriteLine("Nine ball 2 prohibited from back: " +
            //    string.Join(", ", result.Select(num => num.ToString())));

            //return new int[] { };


            return result;
        }



        public static int[] TenBallRackHack()
        {
            int[] middleNumbers = { 2, 3, 4, 5, 6, 7, 8, 9 };


            //int[] middleNumbers = Enumerable.Range(2, 8).Distinct().ToArray();


            middleNumbers = ShuffleArray(middleNumbers);


            // Initialize the result array with 1 at the zeroth index and 9 at the fourth index
            int[] result = new int[10] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 10,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], middleNumbers[6], middleNumbers[7], };



            //Console.WriteLine("Ten ball: " +
            //    string.Join(", ", result.Select(num => num.ToString())));


            return result;
        }


        public static int[] TenBallRackHack2And3OnWings()
        {

            int[] twoAndThree = { 2, 3 };

            int[] fourToNine = { 4, 5, 6, 7, 8, 9 };


            //int[] twoAndThree = Enumerable.Range(2, 2).Distinct().ToArray();

            //int[] fourToNine = Enumerable.Range(4, 6).Distinct().ToArray();


            twoAndThree = ShuffleArray(twoAndThree);


            fourToNine = ShuffleArray(fourToNine);


            int[] result = new int[10] { 1, fourToNine[0], fourToNine[1], fourToNine[2], 10, fourToNine[3],
                twoAndThree[0], fourToNine[4], fourToNine[5], twoAndThree[1] };

            return result;
        }


        private static int[] ShuffleArray(int[] array)
        {
            Random rng = new Random();

            return array.OrderBy(x => rng.Next()).ToArray();
        }
    }
}



/*
 
Controller

    Model

    ViewModel
 
 */


