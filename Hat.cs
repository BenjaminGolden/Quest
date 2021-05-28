

namespace Quest
{
    public class Hat 
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription()
        {
            string shiny = "not shiny";
            if (ShininessLevel < 2)
            {
                shiny = "dull";
            }
            else if (ShininessLevel > 2 && ShininessLevel < 5)
            {
                shiny = "noticeable";
            }
            else if (ShininessLevel > 6 && ShininessLevel < 9)
            {
                shiny = "bright";
            }
            else if (ShininessLevel > 9)
            {
                shiny = "blinding";
            }

            return $"your hat is {shiny}";
        }

    }

}