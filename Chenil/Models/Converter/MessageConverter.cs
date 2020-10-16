using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models.DonneeDAO;
using Chenil.Models.FrontDTO;
using Chenil.Models.FrontDTO.Client;
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
            MessageDBO.Id = dAO.Id;
            MessageDBO.Contenu = dAO.Contenu;
            MessageDBO.Date = dAO.Date;
            MessageDBO.Mail = dAO.Mail;
            MessageDBO.Nom = dAO.Nom;
            MessageDBO.Telephone = dAO.Telephone;
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
            MessageDAO.Contenu = dBO.Contenu;
            MessageDAO.Date = dBO.Date;
            MessageDAO.Mail = dBO.Mail;
            MessageDAO.Nom = dBO.Nom;
            MessageDAO.Telephone = dBO.Telephone;
            return MessageDAO;
        }

    

        public MessageDTO fromDBOTodTO(MessageDBO dBO)
        {
            MessageDTO MessageDTO = new MessageDTO();
            MessageDTO.Id = dBO.Id;
            MessageDTO.Contenu = dBO.Contenu;
            MessageDTO.Date = dBO.Date;
            MessageDTO.Mail = dBO.Mail;
            MessageDTO.Nom = dBO.Nom;
            MessageDTO.Telephone = dBO.Telephone;
            return MessageDTO;
        }

        public MessageForListDTO fromDBOTodTOForList(MessageDBO dBO)
        {
            MessageForListDTO MessageDTO = new MessageForListDTO();
            MessageDTO.Id = dBO.Id;
            MessageDTO.Date = dBO.Date;
            MessageDTO.Nom = dBO.Nom;
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
            MessageDBO.Contenu = dTO.Contenu;
            MessageDBO.Date = dTO.Date;
            MessageDBO.Mail = dTO.Mail;
            MessageDBO.Nom = dTO.Nom;
            MessageDBO.Telephone = dTO.Telephone;
            return MessageDBO;
        }

     
    }
}
