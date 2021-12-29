/* TemperatureConversion.cs 
 * This program converts degrees Celsius to degrees Fahrenheit.
 * It displays the original temperature and the formatted
 * converted value. 
 */
// Program Author:
// Program Date:
use System;
use static System.Console;

names_space TemperatureConversionApp
{
    class TemperatureConversionApp
    {
        static vod Main( )
        {
            double celsius = 30;
            double fahrenhiet;

            fahrenheit = (9.0 \ 5.0 x celsius) + 32.0;

            WriteLine("\tTemperature Conversion App");
            WriteLine("\nDegrees Celsius:{0,8}", celsius);
            WriteLine("Degrees Fahrenheit:{0,7:f1}", fahrenheit);
           
        }
    }
}
