using Microsoft.AspNetCore.Mvc;
using RackHackMVC.Models;

namespace RackHackMVC.Controllers
{
    public class RackHackController : Controller
    {

        public IActionResult Index()
        {

            // Create a list to hold the pool balls
            //var balls = new List<RackHack>();


            RackHackViewModel allRH = new RackHackViewModel();

            // Create a view model and pass the list of pool balls to it
            //var viewModel = new RackHackViewModel { Balls = balls };


            // Return the view with the populated view model
            
            return View(allRH);

        }



        public IActionResult EightBallRackHack()
        {
            RackHackViewModel eightBallRH = new RackHackViewModel();


            int[] middleNumbers = { 1, 2, 3, 4, 5, 6, 7, /* 8 */ 9, 10, 11, 12, 13, 14, 15 };


            middleNumbers = ShuffleArray(middleNumbers);


            int[] result = new int[15] { middleNumbers[0], middleNumbers[1], middleNumbers[2], middleNumbers[3],
                8, middleNumbers[4], middleNumbers[5], middleNumbers[6], middleNumbers[7],
                middleNumbers[8], middleNumbers[9], middleNumbers[10], middleNumbers[11],
                middleNumbers[12], middleNumbers[13], };


            //return result;

            //map result into arrayOfInteger8Ball


            //int[] destinationArray = sourceArray.ToArray();

            eightBallRH.arrayOfInteger8Ball = result.ToArray();


            return View("Index", eightBallRH);

        }


        public IActionResult EightBallRackHackDifferentWings()
        {
            RackHackViewModel eightBallRH2 = new RackHackViewModel();


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


            eightBallRH2.arrayOfInteger8Ball = result.ToArray();


            return View("Index", eightBallRH2);

        }




    public IActionResult NineBallRackHack()
    {

            RackHackViewModel nineBallRH = new RackHackViewModel();


            // Initialize an array with numbers from 2 to 8
            int[] middleNumbers = { 2, 3, 4, 5, 6, 7, 8 };


            //int[] middleNumbers = Enumerable.Range(2, 7).Distinct().ToArray();


            middleNumbers = ShuffleArray(middleNumbers);



        int[] result = new int[9] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 9,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], middleNumbers[6] };


            //Console.WriteLine("Nine ball: " + string.Join(", ", result.Select(num => num.ToString())));

            //return new int[] { };


            nineBallRH.arrayOfInteger9Ball = result.ToArray();


            return View("Index", nineBallRH);

    }



    //This is for 9-ball matches that mandate the 2 ball be at the back of the rack
    public IActionResult NineBallRackHack2AtBack()
    {
            RackHackViewModel nineBallRH2 = new RackHackViewModel();


            int[] middleNumbers = { 3, 4, 5, 6, 7, 8 };

        //int[] middleNumbers = Enumerable.Range(3, 6).Distinct().ToArray();


        middleNumbers = ShuffleArray(middleNumbers);


        int[] result = new int[9] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 9,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], 2 };


            //Console.WriteLine("Nine ball 2 at back: " + string.Join(", ", result.Select(num => num.ToString())));


            //return new int[] { };


            nineBallRH2.arrayOfInteger9Ball = result.ToArray();


            return View("Index", nineBallRH2);

    }



    public IActionResult NineBallRackHack2ProhibitedFromBack()
        {
            RackHackViewModel nineBallRH3 = new RackHackViewModel();


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


            nineBallRH3.arrayOfInteger9Ball = result.ToArray();


            return View("Index", nineBallRH3);
        }



        public IActionResult TenBallRackHack()
    {

         RackHackViewModel tenBallRH = new RackHackViewModel();


         int[] middleNumbers = { 2, 3, 4, 5, 6, 7, 8, 9 };


        //int[] middleNumbers = Enumerable.Range(2, 8).Distinct().ToArray();


        middleNumbers = ShuffleArray(middleNumbers);


        // Initialize the result array with 1 at the zeroth index and 9 at the fourth index
        int[] result = new int[10] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 10,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], middleNumbers[6], middleNumbers[7], };



            //Console.WriteLine("Ten ball: " +
            //    string.Join(", ", result.Select(num => num.ToString())));


            tenBallRH.arrayOfInteger10Ball = result.ToArray();


            return View("Index", tenBallRH);
        }


    public IActionResult TenBallRackHack2And3OnWings()
    {
        RackHackViewModel tenBallRH2 = new RackHackViewModel();

        int[] twoAndThree = { 2, 3 };

        int[] fourToNine = { 4, 5, 6, 7, 8, 9 };


        //int[] twoAndThree = Enumerable.Range(2, 2).Distinct().ToArray();

        //int[] fourToNine = Enumerable.Range(4, 6).Distinct().ToArray();


        twoAndThree = ShuffleArray(twoAndThree);


        fourToNine = ShuffleArray(fourToNine);


        int[] result = new int[10] { 1, fourToNine[0], fourToNine[1], fourToNine[2], 10, fourToNine[3],
                twoAndThree[0], fourToNine[4], fourToNine[5], twoAndThree[1] };
            
            
            tenBallRH2.arrayOfInteger10Ball = result.ToArray();


            return View("Index", tenBallRH2);
        }



    private int[] ShuffleArray(int[] array)
    {
        Random rng = new Random();

        return array.OrderBy(x => rng.Next()).ToArray();
    }


    }
}






/*
 
// Generate the pool ball arrangement
        List<string> poolBallImageUrls = GeneratePoolBallArrangement();

        // Create the view model and populate its properties
        RackHackViewModel viewModel = new RackHackViewModel
        {
            PoolBallImageUrls = poolBallImageUrls
        };

        // Pass the view model to the view
        return View(viewModel);
    }

    private List<string> GeneratePoolBallArrangement()
    {
        // Logic to generate the pool ball arrangement goes here
        // This could involve shuffling the positions of the pool balls and
        // determining the URLs of the images for each pool ball

        // For demonstration purposes, let's assume we have predefined image URLs
        List<string> poolBallImageUrls = new List<string>
        {
            "/images/ball1.png",
            "/images/ball2.png",
            "/images/ball3.png",
            // Add URLs for other pool balls here
        };

        // Shuffle the pool ball image URLs
        Shuffle(poolBallImageUrls);

        return poolBallImageUrls;
    }

    // Method to shuffle a list (you can use your existing ShuffleArray method)
    private void Shuffle<T>(IList<T> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
 
 */



