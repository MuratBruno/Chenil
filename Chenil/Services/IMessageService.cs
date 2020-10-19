using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models.DonneeDAO;
using Chenil.Models.MetierDBO;

namespace Chenil.Services
{
    /// <summary>
    /// Le service Message s'occupe toute oppération intermédiare entre la reception par le controller et l'enregistrement en bdd
    /// </summary>
    public interface IMessageService
    {
        public IQueryable<MessageDTO> GetAll();

        public MessageDTO GetById(int id);

        public MessageDTO Create(MessageDTO entity);

        public MessageDTO Update(MessageDTO entity);

        public MessageDTO Delete(int id);
    }
}
