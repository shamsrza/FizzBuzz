using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {

        private readonly int FizzValue = 3;
        private readonly int BuzzValue = 5;

        bool Fizz = false;
        bool Buzz = false;


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate()
        {
            List<Number> numbers = new List<Number>();

            for (var i = 1; i <= 100; i++)
            {
                //for not repeating this module operation (%) we set these booleans above
                //and here we assign them to the % operations for using in if statement
                Fizz = (i % FizzValue == 0);
                Buzz = (i % BuzzValue == 0);

                //Here is the main logic of program- in which cases we should print "Fizz Buzz", "Fizz" and "Buzz"
                if (Fizz && Buzz)
                {
                    numbers.Add(new Number { Value = "FizzBuzz" });
                }
                else if (Fizz)
                {
                    numbers.Add(new Number { Value = "Fizz" });
                }
                else if (Buzz)
                {
                    numbers.Add(new Number { Value = "Buzz" });
                }
                else
                {
                    numbers.Add(new Number { Value = i.ToString() });
                }

            }

            return View("Index", numbers);
        }

    }
}
