﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check ");
            using (var db = new NorthwindConnect())
            {
                var service = new DataService();
               // var category = service.CreateCategory("Test", "CreateCategory_ValidData_CreteCategoryAndRetunsNewObject");
                service.CreatedCategory(new Category("we","sfs"));
                Console.WriteLine("check ");
            }
        }
    }
}
