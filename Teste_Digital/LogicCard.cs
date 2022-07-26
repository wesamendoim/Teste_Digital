using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Teste_Digital
{
    public class LogicCard
    {
        WeatherForecast propietiesCards = new WeatherForecast();

        public bool CardNumber(string cardNumber)
        {
            if(cardNumber.Length > 16)
            {
                Console.WriteLine("Card number is so much longer");

                return false;

            }else if (cardNumber.Length < 16)
            {
                cardNumber = cardNumber.PadLeft(16, '0');
                propietiesCards.CardNumber = long.Parse(cardNumber);

            }else if (cardNumber.Length == 16)
            {
                propietiesCards.CardNumber = long.Parse(cardNumber);
            }

                return true;
        }

        public bool SecuriteCVV(string numberCVV)
        {
            if(numberCVV.Length > 5)
            {
                Console.WriteLine("Card number is so much longer");

                return false;
            }else if(numberCVV.Length < 5)
            {
                propietiesCards.CVV = int.Parse(numberCVV);
            }

            return true;
        }


        public void NumberOfTimes(int[] arr, int begin, int end)
        {
            while(begin < end)
            {
                int temp = arr[begin];
                arr[begin] = arr[end];
                arr[end] = temp;
                begin++;
                end--;
            }
            
        }

        public void ReverseArrayKTimes(int[] arr, int k)
        {
            NumberOfTimes(arr, 0, arr.Length - 1);
            NumberOfTimes(arr, 0, k - 1);
            NumberOfTimes(arr, k, arr.Length - 1);
        }

      
    }
}
