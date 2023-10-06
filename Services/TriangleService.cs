namespace Services
{
    public class TriangleService
    {
        public string DetermineTypeOfTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return $"It's equilateral triangle";
            }
            else if ((firstSide == secondSide) || (firstSide == thirdSide) || (secondSide == thirdSide))
            {
                return $"It's isoceles triangle";
            }
            else
            {
                return $"It's scalene triangle";
            }
        }
    }
}