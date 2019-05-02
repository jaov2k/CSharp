using System;
/// <summary>
/// Performs the calculations on the inputted values and determines its range.
/// </summary>
/// 
namespace minMaxApp
{
    public static class Calcs
    {
        //Calc the Width to Height ratio: width / height
        public static decimal CalcRatio(decimal InputWidth, decimal InputHeight)
        {
            decimal Ratio = InputWidth / InputHeight;
            return Ratio;
        }
        
        //Calc the area of the two values: width * height
        public static decimal CalcArea(decimal InputWidth, decimal InputHeight)
        {
            decimal Area = InputWidth * InputHeight;
            return Area;
        }

        //Determine which if the three color groups the pair falls within: Red, Green or Blue
        public static string CalcGroup(decimal InputWidth, decimal InputHeight)
        {
            //Receive the values from the form.
            WidthHeight InputWidthHeight = new WidthHeight
            {
                Width = InputWidth,
                Height = InputHeight
            };

            //Set the range of the colors
            ColorRange(out WidthHeight[] Blue, out WidthHeight[] Green, out WidthHeight[] Red);
            
            //Check if in Blue
            foreach (WidthHeight Inputs in Blue)
            {
                if (InputWidthHeight.Width <= Inputs.Width && InputWidthHeight.Height <= Inputs.Height)
                {
                    return "Blue";
                }
            }

            //Check if in Green
            foreach (WidthHeight Inputs in Green)
            {
                if (InputWidthHeight.Width <= Inputs.Width && InputWidthHeight.Height <= Inputs.Height)
                {
                    return "Green";
                }
            }

            //Check if in Red
            foreach (WidthHeight Inputs in Red)
            {
                if (InputWidthHeight.Width <= Inputs.Width && InputWidthHeight.Height <= Inputs.Height)
                {
                    return "Red";
                }
            }

            //Code should never get here.
            return "Never going to see this";
        }

        //Define the color ranges.
        static void ColorRange(out WidthHeight[] blue, out WidthHeight[] green, out WidthHeight[] red)
        {
            //Define the Blue range
            blue = new WidthHeight[] {
                new WidthHeight() { Width = 0.00M, Height = 4.00M },
                new WidthHeight() { Width = 2.00M, Height = 4.00M },
                new WidthHeight() { Width = 2.00M, Height = 3.00M },
                new WidthHeight() { Width = 3.00M, Height = 3.00M },
                new WidthHeight() { Width = 3.00M, Height = 2.00M },
                new WidthHeight() { Width = 7.00M, Height = 2.00M },
                new WidthHeight() { Width = 7.00M, Height = 0.00M },
            };


            //Define the Green range
            green = new WidthHeight[] {
                new WidthHeight() { Width = 0.00M, Height = 8.00M },
                new WidthHeight() { Width = 2.00M, Height = 8.00M },
                new WidthHeight() { Width = 2.00M, Height = 7.00M },
                new WidthHeight() { Width = 5.00M, Height = 7.00M },
                new WidthHeight() { Width = 5.00M, Height = 5.00M },
                new WidthHeight() { Width = 6.00M, Height = 5.00M },
                new WidthHeight() { Width = 6.00M, Height = 3.00M },
                new WidthHeight() { Width = 8.00M, Height = 3.00M },
                new WidthHeight() { Width = 8.00M, Height = 2.00M },
                new WidthHeight() { Width = 9.00M, Height = 2.00M },
                new WidthHeight() { Width = 9.00M, Height = 0.00M },
            };

            //Define the Red range
            red = new WidthHeight[] {
                new WidthHeight() { Width = 0.00M, Height = 10.00M },
                new WidthHeight() { Width = 10.00M, Height = 10.00M },
                new WidthHeight() { Width = 10.00M, Height = 0.00M },
            };
        }
    }
}
