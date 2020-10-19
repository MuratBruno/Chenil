using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Data;
using Chenil.Models;
using Chenil.Models.Converter;
using Chenil.Models.DonneeDAO;
using Chenil.Models.MetierDBO;
using Chenil.Repository;
using Chenil.Repository.Impl;
using Chenil.Services;
using Chenil.Services.Impl;

namespace Chenil.Controllers
{
    /// <summary>
    /// Controller du Message : gestion des routes, reception des requetes http et redirection vers le service concerné
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : Controller
    {
        IMessageService MessageService;
        public MessageController(IMessageService MessageService)
        {
            this.MessageService = MessageService;
        }

        //Pour les tests unitaires
        //TODO : si on ne peut pas utiliser l'injection de dépendance.
        public static MessageController getMessageController()
        {
            return new MessageController(MessageServiceImpl.getMessageServiceImpl());
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<MessageDTO> GetById(int id)
        {
            MessageDTO MessageDTO = new MessageDTO();
            try
            {
                if (ModelState.IsValid)
                {
                    return   MessageService.GetById(id);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur lors de l'enregistrement");
            }
            return MessageDTO;
        }

        [HttpPost]
        public ActionResult<MessageDTO> Create(MessageDTO Message)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return MessageService.Create(Message);

                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur lors de l'enregistrement");
            }
            return Message;
        }

        [HttpPut]
        public ActionResult<MessageDTO> Update(MessageDTO Message)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    return MessageService.Update(Message);

                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur lors de l'enregistrement");
            }
            return Message;
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<MessageDTO> Delete(int id)
        {
            MessageDTO Message = new MessageDTO();
            try
            {
                if (ModelState.IsValid)
                {
                    
                    return MessageService.Delete(id);

                }
            }
            catch (Exception e)
            {
                throw new Exception("Erreur lors de l'enregistrement");
            }
            return Message;
        }
    }
}
