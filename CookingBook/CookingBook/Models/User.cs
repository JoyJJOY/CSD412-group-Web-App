﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingBook.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public IEnumerable<Recipe> RecipeBook {get; set;}

    }
}
