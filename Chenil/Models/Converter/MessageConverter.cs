using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models.DonneeDAO;
using Chenil.Models.MetierDBO;

namespace Chenil.Models.Converter
{
    /// <summary>
    /// Cette classe permer d'effectuer des conversion entre les classes MessageDAO, MessageDBO et MessageDTO
    /// </summary>
    public class MessageConverter : IConverter<MessageDAO, MessageDBO, MessageDTO>
    {
        //Pattern singleton
        private static MessageConverter messageConverter;
        public static MessageConverter getConverter()
        {
            if (messageConverter == null)
            {
                messageConverter = new MessageConverter();
            }
            return messageConverter;
        }

        //Constructeur privé
        private MessageConverter()
        {

        }



        public MessageDBO fromDAOTodBO(MessageDAO dAO)
        {
            MessageDBO MessageDBO = new MessageDBO();
            MessageDBO.id = dAO.id;
            return MessageDBO;
        }

        public MessageDTO fromDAOTodTO(MessageDAO dAO)
        {
            MessageDBO MessageDBO =fromDAOTodBO(dAO);
            MessageDTO MessageDTO = fromDBOTodTO(MessageDBO);
            return MessageDTO;
        }

        public MessageDAO fromDBOTodAO(MessageDBO dBO)
        {
            MessageDAO MessageDAO = new MessageDAO();
            MessageDAO.id = dBO.id;
            return MessageDAO;
        }

    

        public MessageDTO fromDBOTodTO(MessageDBO dBO)
        {
            MessageDTO MessageDTO = new MessageDTO();
            MessageDTO.id = dBO.id;
            return MessageDTO;
        }

        public MessageDAO fromDTOTodAO(MessageDTO dTO)
        {
            MessageDBO MessageDBO = fromDTOTodBO(dTO);
            MessageDAO MessageDAO = fromDBOTodAO(MessageDBO);
            return MessageDAO;
        }

        public MessageDBO fromDTOTodBO(MessageDTO dTO)
        {
            MessageDBO MessageDBO = new MessageDBO();
            MessageDBO.id = dTO.id;
            return MessageDBO;
        }


    }
}
