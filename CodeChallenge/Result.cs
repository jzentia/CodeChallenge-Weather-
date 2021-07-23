using System;
using Service.Weather.Model;

namespace CodeChallenge
{
    class Result
    {
        /// <summary>
        /// Methond generating result 
        /// </summary>
        /// <param name="response"></param>
        public static void GenerateResult(ServiceResponse response)
        {
            if (response == null)
            {
                Console.WriteLine("Invalid ZipCode");
                return;
            }
            Console.WriteLine("Should I go outside?");
            Console.WriteLine(response.Go_OutSide ? "Yes" : "No");

            Console.WriteLine("Should I wear sunscreen?");
            Console.WriteLine(response.Wear_SunScreen ? "Yes" : "No");

            Console.WriteLine("Can I fly my kite?");
            Console.WriteLine(response.Fly_Kite ? "Yes" : "No");
        }
        /// <summary>
        /// Methond accepting zipcode from user
        /// </summary>
        /// <returns></returns>
        public static string InputZipCode()
        {
            Console.WriteLine("Please input ZipCode: ");
            string zipCode = Console.ReadLine();
            return zipCode;
        }
    }
}
