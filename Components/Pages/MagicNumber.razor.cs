using Microsoft.AspNetCore.Components;

namespace BlazorAppTest.Components.Pages
{
    public class MagicNumberBase : ComponentBase
    {
        protected const int NumberLifeMax = 5;
        protected const int NumberMax = 20;

        protected int value;
        protected int NumberMagic;
        protected int NumberRemainigLife;
        protected bool? GameWon;


        protected override void OnInitialized()
        {
            var random = new Random();
            NumberMagic = random.Next(NumberMax);

            NumberRemainigLife = NumberLifeMax;

            base.OnInitialized();
        }

        protected void TestNumber()
        {
            Console.WriteLine("TestNumber is called");
            if(value == NumberMagic)
            {
                GameWon = true;
            } else
            {
                NumberRemainigLife--;

                if(NumberRemainigLife == 0)
                {
                    GameWon = false;
                }
            }
        }
    }
}
