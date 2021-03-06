﻿using System.ComponentModel;
using System.Runtime.Serialization;

namespace Midway.ObjectModel.GoodsTransportWaybill
{
    /// <summary>
    /// Версия формата титула водителя (прием груза) товарно-транспортной накладной.
    /// </summary>
    [DataContract]
    public enum GoodsTransportWaybillCargoReceivedTitleFormatVersion
    {
        /// <summary>
        /// Не указана.
        /// </summary>
        [EnumMember]
        [Description("Не указана")]
        None = 0,

        /// <summary>
        /// Версия 1.00.
        /// </summary>
        [EnumMember]
        [Description("Версия 1.00")]
        V100 = 1,
    }
}
