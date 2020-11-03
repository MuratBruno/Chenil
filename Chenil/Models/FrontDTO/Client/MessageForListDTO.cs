using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Chenil.Models.FrontDTO.Client
{
    /// <summary>
    /// Classe d'affichage réduit des messages lorsqu'ils sont en grand nombre dans une liste.
    /// </summary>
    public class MessageForListDTO
    {

        public int Id { get; set; }
        public string Nom { get; set; }

        public string Objet { get; set; }
        public DateTime Date { get; set; }
    }
}
