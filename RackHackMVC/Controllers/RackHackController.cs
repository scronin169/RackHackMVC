using Microsoft.AspNetCore.Mvc;
using RackHackMVC.Models;

namespace RackHackMVC.Controllers
{
    public class RackHackController : Controller
    {

        public IActionResult Index()
        {
            RackHackViewModel allRH = new RackHackViewModel();
            
            
            return View(allRH);

        }





        public IActionResult EightBallRackHack()
        {
            RackHackViewModel eightBallRH = new RackHackViewModel();

            eightBallRH.EightBallRackHackClick = true;

            int[] middleNumbers = { 1, 2, 3, 4, 5, 6, 7, /* 8 */ 9, 10, 11, 12, 13, 14, 15 };


            middleNumbers = ShuffleArray(middleNumbers);


            int[] result = new int[15] { middleNumbers[0], middleNumbers[1], middleNumbers[2], middleNumbers[3],
                8, middleNumbers[4], middleNumbers[5], middleNumbers[6], middleNumbers[7],
                middleNumbers[8], middleNumbers[9], middleNumbers[10], middleNumbers[11],
                middleNumbers[12], middleNumbers[13] };


            eightBallRH.PoolBalls = result.ToList();


            return View("Index", eightBallRH);

        }





        public IActionResult EightBallRackHackDifferentWings()
        {
            RackHackViewModel eightBallRH2 = new RackHackViewModel();


            eightBallRH2.EightBallRackHackDifferentWingsClick = true;


            int[] middleNumbers = { 1, 2, 3, 4, 5, 6, 7,/* 8 */ 9, 10, 11, 12, 13, 14, 15 };


            middleNumbers = ShuffleArray(middleNumbers);


            //This checks if the wing balls are of the same group, if so, it reshuffles
            while (middleNumbers[9] < 8 && middleNumbers[13] < 8 ||
                middleNumbers[9] > 8 && middleNumbers[13] > 8)
            {
                middleNumbers = ShuffleArray(middleNumbers);
            }


            int[] result = new int[15] { middleNumbers[0], middleNumbers[1], middleNumbers[2], middleNumbers[3],
                8, middleNumbers[4], middleNumbers[5], middleNumbers[6], middleNumbers[7], middleNumbers[8],
                middleNumbers[9], middleNumbers[10], middleNumbers[11], middleNumbers[12], middleNumbers[13] };


            eightBallRH2.PoolBalls = result.ToList();


            return View("Index", eightBallRH2);

        }




    public IActionResult NineBallRackHack()
    {

            RackHackViewModel nineBallRH = new RackHackViewModel();


            nineBallRH.NineBallRackHackClick = true;


            int[] middleNumbers = { 2, 3, 4, 5, 6, 7, 8 };


            middleNumbers = ShuffleArray(middleNumbers);


        int[] result = new int[9] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 9,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], middleNumbers[6] };


            nineBallRH.PoolBalls = result.ToList();


            return View("Index", nineBallRH);

    }



    //This is for 9-ball matches that mandate the 2 ball be at the back of the rack
    public IActionResult NineBallRackHack2AtBack()
    {
            RackHackViewModel nineBallRH2 = new RackHackViewModel();


            nineBallRH2.NineBallRackHack2AtBackClick = true;



            int[] middleNumbers = { 3, 4, 5, 6, 7, 8 };


        middleNumbers = ShuffleArray(middleNumbers);


        int[] result = new int[9] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 9,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], 2 };


            nineBallRH2.PoolBalls = result.ToList();


            return View("Index", nineBallRH2);

        }






    //This is for 9-ball matches that prohibit the 2 ball from being at the back of the rack
    public IActionResult NineBallRackHack2ProhibitedFromBack()
        {
            RackHackViewModel nineBallRH3 = new RackHackViewModel();


            nineBallRH3.NineBallRackHack2ProhibitedFromBackClick = true;


            int[] middleNumbers = { 2, 3, 4, 5, 6, 7, 8 };


            middleNumbers = ShuffleArray(middleNumbers);


            // This checks if the 7th element is 2, if so, it reshuffles
            while (middleNumbers[6] == 2)
            {
                middleNumbers = ShuffleArray(middleNumbers);
            }



            int[] result = new int[9] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 9,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], middleNumbers[6] };



            nineBallRH3.PoolBalls = result.ToList();


            return View("Index", nineBallRH3);
        }




        public IActionResult TenBallRackHack()
    {

         RackHackViewModel tenBallRH = new RackHackViewModel();


            tenBallRH.TenBallRackHackClick = true;


            int[] middleNumbers = { 2, 3, 4, 5, 6, 7, 8, 9 };



        middleNumbers = ShuffleArray(middleNumbers);


        int[] result = new int[10] { 1, middleNumbers[0], middleNumbers[1], middleNumbers[2], 10,
                middleNumbers[3], middleNumbers[4], middleNumbers[5], middleNumbers[6], middleNumbers[7], };


            tenBallRH.PoolBalls = result.ToList();


            return View("Index", tenBallRH);
        }


    public IActionResult TenBallRackHack2And3OnWings()
    {
        RackHackViewModel tenBallRH2 = new RackHackViewModel();


        tenBallRH2.TenBallRackHack2And3OnWingsClick = true;


        int[] twoAndThree = { 2, 3 };

        int[] fourToNine = { 4, 5, 6, 7, 8, 9 };


        twoAndThree = ShuffleArray(twoAndThree);


        fourToNine = ShuffleArray(fourToNine);


        int[] result = new int[10] { 1, fourToNine[0], fourToNine[1], fourToNine[2], 10, fourToNine[3],
                twoAndThree[0], fourToNine[4], fourToNine[5], twoAndThree[1] };
            
            
            tenBallRH2.PoolBalls = result.ToList();


            return View("Index", tenBallRH2);
        }



    private int[] ShuffleArray(int[] array)
    {
        Random rng = new Random();

        return array.OrderBy(x => rng.Next()).ToArray();
    }


    }
}





