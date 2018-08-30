using System;

namespace _04PhotoGallery
{
    // Program, which receives image metadata as input and prints information about the image, such as its filename, date taken, size, resolution and aspect ratio.
    public class Launcher
    {
        public static void Main()
        {
            var photosNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var photoSize = double.Parse(Console.ReadLine());
            var widht = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            PrintInformationAboutImage(photosNumber, day, month, year, hour, minute, photoSize, widht, height);
        }

        private static void PrintInformationAboutImage
            (int photosNumber, int day, int month, int year, int hour, int minute, double photoSize, int widht, int height)
        {
            Console.WriteLine($"Name: DSC_{photosNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minute:D2}");

            PrintImagePhotoSize(photoSize);
            PrintImageResolution(widht, height);
        }

        private static void PrintImageResolution(int widht, int height)
        {
            if (widht == height)
                Console.WriteLine($"Resolution: {widht}x{height} (square)");
            else if (widht < height)
                Console.WriteLine($"Resolution: {widht}x{height} (portrait)");
            else if (widht > height)
                Console.WriteLine($"Resolution: {widht}x{height} (landscape)");
        }

        private static void PrintImagePhotoSize(double photoSize)
        {
            if (photoSize < 999)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize > 999999)
            {
                var mb = photoSize / 1000000;
                Console.WriteLine($"Size: {mb}MB");
            }
            else
            {
                var kb = photoSize / 1000;
                Console.WriteLine($"Size: {kb}KB");
            }
        }
    }
}