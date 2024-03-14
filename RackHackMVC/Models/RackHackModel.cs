
namespace RackHackMVC.Models
{
    public class RackHackModel
    {
        public int[] PoolBalls { get; set; }

        public RackHackModel(int[] poolBalls)
        {
            PoolBalls = poolBalls;
        }


        //one function that takes two variables.
        //first var represents the game,
        //second var respresents rule set.
        //if second var is null then default to basic rule set
        //make second variable optional
        public void functionOne(int game, string ruleSet = null)
        {
            if (game == 8)
            {                
                //call EightBallRackHack()
            }


            if (game == 8 && ruleSet == "Differing wings")
            {
                //call EightBallRackHackDifferentWings()
            }


            if(game == 9)
            {
                //call NineBallRackHack()
            }


            if(game == 9 && ruleSet == "two at back")
            {
                //call NineBallRackHack2AtBack()
            }

            
            if(game == 9 && ruleSet == "two prohibited from back")
            {
                //call NineBallRackHack2ProhibitedFromBack()
            }


            if(game == 10)
            {
                //call TenBallRackHack()
            }


            if (game == 10 && ruleSet == "2 and 3 on wings")
            {
                //call TenBallRackHack2And3OnWings()
            }
        }

    }
}



//viewModel
//controller
//views






