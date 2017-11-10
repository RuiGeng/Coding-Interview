using System;

namespace Question2
{
    internal class Program
    {
        private static String location;
        private static DateTime time;

        /// <summary>
        /// What is the output of the short program below? Explain your answer.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Question();
            Console.ReadLine();
        }

        /// <summary>
        /// Although both variables are uninitialized, String is a reference type and DateTime is a value type.As a value type, 
        /// an unitialized DateTime variable is set to a default value of midnight of 1/1/1 (yup, that’s the year 1 A.D.), not null.
        /// </summary>
        public static void Question()
        {
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
        }
    }
}


//Reference Types
//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
//There are two kinds of types in C#: reference types and value types.
//Variables of reference types store references to their data (objects), while variables of value types directly contain their data.
//With reference types, two variables can reference the same object;
//therefore, operations on one variable can affect the object referenced by the other variable.
//With value types, each variable has its own copy of the data,
//and it is not possible for operations on one variable to affect the other (except in the case of ref and out parameter variables, see ref and out parameter modifier).
//The following keywords are used to declare reference types:
////class
////interface
////delegate
//C# also provides the following built-in reference types:
////dynamic
////object
////string

//Value Types
//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types
//The value types consist of two main categories:
////Structs
////Enumerations

//Structs fall into these categories:
////Numeric types
////Integral types
////Floating-point types
////decimal
//bool
//User defined structs.