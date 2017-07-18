﻿using System.Runtime.Serialization;

namespace Midway.Edi.Api.Models
{
    /// <summary>
    /// Запрос на получение документа
    /// </summary>
    [DataContract]
    public class GetDocumentRequest
    {
        /// <summary>
        /// Учетные данные запроса
        /// </summary>
        [DataMember(IsRequired = true)]
        public RequestCredentials Credentials { get; set; }

        /// <summary>
        /// Имя файла документа
        /// </summary>
        [DataMember(IsRequired = true)]
        public string FileName { get; set; }
    }
}