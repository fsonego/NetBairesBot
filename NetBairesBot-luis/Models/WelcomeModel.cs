﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetBairesBot_LUIS.Models
{
    public class WelcomeModel
    {
        List<String> _welcomes;

        public WelcomeModel()
        {
            _welcomes.Add("Bienvenido, pregúntame lo que quieras saber1.");
            _welcomes.Add("Bienvenido, pregúntame lo que quieras saber2.");
            _welcomes.Add("Bienvenido, pregúntame lo que quieras saber3.");
        }
        //public string GetRandowmWelcome() { 
        
        //}
    }
}
