using Microsoft.AspNetCore.Mvc;
using NordeaBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordeaBank.Controllers
{
    public class HomeController : Controller
    {

        private readonly int NordeaValue = 3;
        private readonly int BankValue = 5;

        bool Nordea = false;
        bool Bank = false;
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate()
        {
            List<Number> numbers = new List<Number>();

            for (var i=1; i <=100; i++)
            {
                //for not repeating this module operation (%) we set these booleans above
                //and here we assign them to the % operations for using in if statement
                Nordea = (i % NordeaValue == 0);
                Bank = (i % BankValue == 0);

                //Here is the main logic of program- in which cases we should print "Nordea Bank", "Nordea" and "Bank"
                if (Nordea && Bank)
                {
                    numbers.Add(new Number { Value = "Nordea Bank"});
                }
                else if (Nordea)
                {
                    numbers.Add(new Number { Value = "Nordea"});
                }
                else if (Bank)
                {
                    numbers.Add(new Number { Value = "Bank"});
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
