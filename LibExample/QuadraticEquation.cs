namespace LibExample
{
    public class QuadraticEquation
    {
        public static double[] Solve(double a, double b, double c)
        { 
            var discriminant = b * b - 4 * a * c;

            if (discriminant == 0)
                return new[] { -b / (2 * a) };
            else if (discriminant < 0)
                return new double[] { };
            else
                return new[] { (-b + Math.Sqrt(discriminant)) / (2 * a),
                               (-b - Math.Sqrt(discriminant)) / (2 * a)};
        }
    }
}
