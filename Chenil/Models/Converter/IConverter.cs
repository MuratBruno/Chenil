using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chenil.Models.Converter
{
    /// <summary>
    /// Cette Interface établit les fonctions de conversion entre les couches DAO,DBO et DTO
    /// </summary>
    /// <typeparam name="DAO"></typeparam>
    /// <typeparam name="DBO"></typeparam>
    /// <typeparam name="DTO"></typeparam>
    interface IConverter<DAO,DBO,DTO>
    {
        public DBO fromDTOTodBO(DTO dTO);
        public DBO fromDAOTodBO(DAO dAO);
        public DAO fromDBOTodAO(DBO dBO);
        public DTO fromDBOTodTO(DBO dBO);

        public DAO fromDTOTodAO(DTO dTO);
        public DTO fromDAOTodTO(DAO dAO);

    }
}
