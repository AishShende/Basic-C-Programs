using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            // Multiplies two integers and returns the result
             int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }

            // Subtracts smaller number from the bigger number
            int Subtract(int num1, int num2)
            {
                if (num1 > num2)
                {
                    return num1 - num2;
                }

                return num2 - num1;
            }

            // Performs division on two float variables
            float Division(float num1, float num2)
            {
                return num1 / num2;
            }
        }
    }
        }
   
