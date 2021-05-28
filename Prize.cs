using System;
namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer anAdventurer)
        {
            int awesomenessScore = anAdventurer.Awesomeness;
            
            for (int i = 0; i < awesomenessScore; i++)
            {
                
                Console.WriteLine($"{_text} ");
            }
            if (awesomenessScore < 0)
            {
                Console.WriteLine("no awesomeness found!");
            }
        }
    }
}