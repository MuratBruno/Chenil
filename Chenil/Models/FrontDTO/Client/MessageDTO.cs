using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models.MetierDBO;

namespace Chenil.Models.DonneeDAO
{
    /// <summary>
    /// Classe du Message tel qu'il sera utiisée par la partie front.
    /// D'autre DTO représentant le Message peuvent exister selon l'affichage voulu, exemple : MessageDetailsDTO.
    /// </summary>
    public class MessageDTO 
    {
        public int id { get; set; }

        //Nombre d'achat effectué par le Message, ce nombre ne servant que la partie front, il n'apparait que dans le DTO
        public int nbAchat { get; set; }
    }
}
