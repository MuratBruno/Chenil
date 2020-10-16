﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models.DonneeDAO;

namespace Chenil.Models.MetierDBO
{
    public class MessageDBO 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Contenu { get; set; }
        public DateTime Date { get; set; }
    }
}
