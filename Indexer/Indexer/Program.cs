using System;
using Indexer.Models;
using Indexer.CustomArray;
using Indexer.Exceptions;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");

            string name = Console.ReadLine();

            Console.Write("Enter your surname : ");

            string surname = Console.ReadLine();

            ReEnterAge:

            Console.Write("Enter your age : ");

            int age;
            try
            {
                age = ConvertInputToInt();
            }
            catch (InputIsNullOrEmptyException exception)
            {
                Console.WriteLine(exception.Message);
                goto ReEnterAge;
            }
            catch (InputIsNotNumberException exception)
            {
                Console.WriteLine(exception.Message);
                goto ReEnterAge;
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured. Please try again.");
                goto ReEnterAge;
            }

            if(age < 0 || age > 150)
            {
                Console.WriteLine("Please re-enter age correctly!");
                goto ReEnterAge;
            }

            ReEnterHeight:

            Console.Write("Enter your height : ");

            int height;
            try
            {
                height = ConvertInputToInt();
            }
            catch (InputIsNullOrEmptyException exception)
            {
                Console.WriteLine(exception.Message);
                goto ReEnterHeight;
            }
            catch (InputIsNotNumberException exception)
            {
                Console.WriteLine(exception.Message);
                goto ReEnterHeight;
            }
            catch (Exception)
            {
                Console.WriteLine("Error occured. Please try again.");
                goto ReEnterHeight;
            }

            if (height < 0 || height > 300)
            {
                Console.WriteLine("Please re-enter height correctly!");
                goto ReEnterAge;
            }

            Person person = new Person(name, surname, age, height);

            CustomArray<Person> customArray = new CustomArray<Person>(1);

            customArray[0] = person;

            for (int i = 0; i < customArray.Length; i++)
            {
                Console.WriteLine($"-------- Id : {i} --------\nName : {customArray[i].Name}\nSurname : {customArray[i].Surname}\nAge : {customArray[i].Age}\nHeight : {customArray[i].Height}sm");
            }

        }

        /// <summary>
        /// Converts input string to integer number.
        /// </summary>
        /// <returns>converted integer number</returns>
        /// <exception cref="InputIsNullOrEmptyException">input string is null or empty.</exception>
        /// <exception cref="InputIsNotNumberException">input string do not contain any number.</exception>
        public static int ConvertInputToInt()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) throw new InputIsNullOrEmptyException("Input is null or empty.");

            int convertedInput;

            try
            {
                convertedInput = Convert.ToInt32(input);
            }
            catch (Exception)
            {
                throw new InputIsNotNumberException("Input is not number.");
            }
            return convertedInput;
        }
    }
}
