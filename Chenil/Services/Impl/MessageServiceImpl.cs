using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models.Converter;
using Chenil.Models.DonneeDAO;
using Chenil.Models.MetierDBO;
using Chenil.Repository;
using Chenil.Repository.Impl;

namespace Chenil.Services.Impl
{
    /// <summary>
    /// Le service Message s'occupe toute oppération intermédiare entre la reception par le controller et l'enregistrement en bdd
    /// </summary>
    public class MessageServiceImpl : IMessageService
    {
        IMessageRepository MessageRepository;

        MessageConverter converter=MessageConverter.getConverter();
        public MessageServiceImpl(IMessageRepository MessageRepository)
        {
            this.MessageRepository = MessageRepository;
        }

        //Pour les tests unitaires
        /*public static MessageServiceImpl getMessageServiceImpl()
        {
            return new MessageServiceImpl(MessageRepositoryImpl.getRepositoryImpl());
        }*/

        /// <summary>
        /// Ajout de la date et l'heure actuelle puis enregistrement en bdd.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public MessageDTO Create(MessageDTO entity)
        {
            MessageDBO MessageDBO = converter.fromDTOTodBO(entity);
            MessageDBO.Date = DateTime.Now;

            MessageDAO MessageDAO = converter.fromDBOTodAO(MessageDBO);

            MessageDAO resultMessageDAO = MessageRepository.Create(MessageDAO).Result;
            MessageDTO resultMessageDTO = converter.fromDAOTodTO(resultMessageDAO);
            return resultMessageDTO;
        }

        public MessageDTO Delete(int id)
        {
            MessageDAO resultMessageDAO = MessageRepository.Delete(id).Result;
            MessageDTO resultMessageDTO = converter.fromDAOTodTO(resultMessageDAO);
            return resultMessageDTO;
        }

        public IQueryable<MessageDTO> GetAll()
        {
            IQueryable<MessageDAO> resultMessageDAOQueryable = MessageRepository.GetAll();
            List<MessageDTO> resultMessageDTOList = new List<MessageDTO>();
            foreach (MessageDAO MessageDAO in resultMessageDAOQueryable)
            {
                MessageDTO resultMessageDTO = converter.fromDAOTodTO(MessageDAO);
                resultMessageDTOList.Add(resultMessageDTO);
            }
            return resultMessageDTOList.AsQueryable<MessageDTO>();
        }

        public MessageDTO GetById(int id)
        {
            MessageDAO resultMessageDAO = MessageRepository.GetById(id).Result;
            MessageDTO resultMessageDTO = converter.fromDAOTodTO(resultMessageDAO);
            return resultMessageDTO;
        }

        public MessageDTO Update( MessageDTO entity)
        {
            MessageDAO MessageDAO = converter.fromDTOTodAO(entity);
            MessageDAO resultMessageDAO = MessageRepository.Update(MessageDAO).Result;
            MessageDTO resultMessageDTO = converter.fromDAOTodTO(resultMessageDAO);
            return resultMessageDTO;
        }
    }
}
