﻿using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// Статус получения документа при отправке нескольким получателям
    /// </summary>
    [DataContract]
    public enum DocumentMultiDeliveryStatus
    {
        /// <summary>
        /// Документ получен сервером. 
        /// Статус означает, что сервис принял документ, но еще не передал его получателям (или другим операторам)
        /// </summary>
        [EnumMember]
        RecievedByService = 0x00,

        /// <summary>
        /// Документ отправлен всем получателям. 
        /// Статус означает, что для всех получателей выполняется одно из условий:
        /// а) если получатель локальный, то документ находится в папке входящих получателя;
        /// б) если получатель зарегистрирован у другого оператора, то сервис передал документ оператору по протоколу роуминга, и
        ///    в этом случае за доставку документа уже отвечает оператор получателя.
        /// </summary>
        [EnumMember]
        SentToRecipients = 0x01,

        /// <summary>
        /// Документ доставлен всем получателям. 
        /// Статус означает, что получено подтверждение о доставке документа от всех получателей.
        /// </summary>
        [EnumMember]
        DeliveredToRecipients = 0x2,

        /// <summary>
        /// Документ не доставлен получателям. 
        /// Статус означает, что отправителем получена квитанция об ошибке от сервиса.
        /// </summary>
        [EnumMember]
        NotDeliveredToRecipients = 0x3,

        /// <summary>
        /// Документ частично доставлен получателям. 
        /// Статус означает, что получено подтверждение о доставке документа от нескольких, но не всех получателей.
        /// </summary>
        [EnumMember]
        PartlyDeliveredToRecipients = 0x4,
    }
}