﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExceptions
{
    class Person
    {
        private String name;

        public String Name
        {
            get { return name; }
            set {
                try
                {
                    //if (value == null)
                    //    throw new NullReferenceException("name must have a value");
                    //name = value;

                    name = value ?? throw new NullReferenceException("name must have a value"); // simplified
                }
                catch (Exception)
                {

                    Console.WriteLine("name can not be null");
                    throw; // will proxy the exception up the chain and both exceptions will be shown.
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var person = new Person();
                person.Name = null;
            }
            catch (EncoderFallbackException ex)
            {
                Console.WriteLine(ex);
            }
            catch (NullReferenceException ex) // chaining catch blocks
            {
                Console.WriteLine(ex);
            }
        }
    }
}
