using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Data;
using Chenil.Models;
using Chenil.Models.Converter;
using Chenil.Models.DonneeDAO;
using Chenil.Models.MetierDBO;

namespace Chenil.Repository.Impl
{
    public class MessageRepositoryImpl : IMessageRepository
    {
        private ChenilContext MessageContext { get; set; }
        public MessageRepositoryImpl(ChenilContext MessageContext)
        {
            this.MessageContext = MessageContext;
        }

        //Pour les tests unitaires
        public static MessageRepositoryImpl getRepositoryImpl()
        {
            return new MessageRepositoryImpl(ChenilContext.getContext());
        }

        public async Task<MessageDAO> Create(MessageDAO MessageDAO)
        {
            MessageContext.Add(MessageDAO);
            await MessageContext.SaveChangesAsync();
            return MessageDAO;
        }

        public async Task<MessageDAO> Delete(int id)
        {
            MessageDAO MessageDAO =MessageContext.Messages.Find(id);
            MessageContext.Remove(id);
            await MessageContext.SaveChangesAsync();
            return MessageDAO;
        }

        public IQueryable<MessageDAO> GetAll()
        {
            return MessageContext.Messages;
        }

        public async Task<MessageDAO> GetById(int id)
        {
            return await MessageContext.Messages.FindAsync(id);           
        }

        public async Task<MessageDAO> Update( MessageDAO entity)
        {
            MessageContext.Update(entity);
            await MessageContext.SaveChangesAsync();
            return entity;
        }
    }
}
