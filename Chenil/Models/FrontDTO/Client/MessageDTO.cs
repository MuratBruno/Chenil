using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models.MetierDBO;

namespace Chenil.Models.DonneeDAO
{
    /// <summary>
    /// Classe front détaillé d'un message de demande de contact
    /// tel qu'il transitera dans les requêtes http
    /// </summary>
    public class MessageDTO 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }
        public string Objet { get; set; }
        public string Contenu { get; set; }
        public DateTime Date { get; set; }
    }
}
