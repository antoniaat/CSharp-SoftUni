namespace _10.CubeProperties
{
    using System;

    public class CubeProperties
    {
        public static void Main()
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                Console.WriteLine(PrintFaceDiagonals(sideOfTheCube));
            }
            else if (parameter == "space")
            {
                Console.WriteLine(PrintSpaceDiagonals(sideOfTheCube));
            }
            else if (parameter == "volume")
            {
                Console.WriteLine(PrintVolumeArea(sideOfTheCube));
            }
            else if (parameter == "area")
            {
                Console.WriteLine(PrintSurfaceArea(sideOfTheCube));
            }
        }

        public static double PrintFaceDiagonals(double sideOfTheCube)
        {
            var secondDegree = Math.Pow(sideOfTheCube, 2);
            var faceDiagonal = Math.Sqrt(2 * secondDegree);
            faceDiagonal = Math.Round(faceDiagonal, 2);
            return faceDiagonal;
        }

        public static double PrintSpaceDiagonals(double sideOfTheCube)
        {
            var secondDegree = Math.Pow(sideOfTheCube, 2);
            var spaceDiagonal = Math.Sqrt(3 * secondDegree);
            spaceDiagonal = Math.Round(spaceDiagonal, 2);

            return spaceDiagonal;
        }

        public static double PrintVolumeArea(double sideOfTheCube)
        {
            var volumeArea = Math.Pow(sideOfTheCube, 3);
            volumeArea = Math.Round(volumeArea, 2);

            return volumeArea;
        }

        public static double PrintSurfaceArea(double sideOfTheCube)
        {
            var surfaceArea = 6 * (Math.Pow(sideOfTheCube, 2));
            surfaceArea = Math.Round(surfaceArea, 2);

            return surfaceArea;
        }
    }
}