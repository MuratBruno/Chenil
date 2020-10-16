using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models;
using Chenil.Models.DonneeDAO;
using Chenil.Models.MetierDBO;

namespace Chenil.Repository
{
    public interface IMessageRepository
    {
        public IQueryable<MessageDAO> GetAll();

        public  Task<MessageDAO> GetById(int id);

        public  Task<MessageDAO> Create(MessageDAO entity);

        public  Task<MessageDAO> Update(MessageDAO entity);

        public  Task<MessageDAO> Delete(int id);
    }
}
