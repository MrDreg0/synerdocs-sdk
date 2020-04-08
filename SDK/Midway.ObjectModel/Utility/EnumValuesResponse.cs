﻿



/*
 ****************************************************************************************************************
 * WARNING: Do not edit this class. It is automatically generated using T4 and any changes will be overwritten. *
 ****************************************************************************************************************
 */

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Midway.ObjectModel.Utility
{
    /// <summary>
    /// Ответ при получении значений перечислений.
    /// </summary>
    [DataContract]
	public class EnumValuesResponse
	{
		/// <summary>
		/// Значения перечисления типа 'Статус работы'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ActivityStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип записи адреса'.
		/// </summary>
		[DataMember]
		public List<EnumValue> AddressLocationTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип адреса'.
		/// </summary>
		[DataMember]
		public List<EnumValue> AddressTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Перечисление групп приложений'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ApplicationGroupTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Обстоятельства формирования счета-фактуры, применяемого при расчетах по налогу на добавленную стоимость'.
		/// </summary>
		[DataMember]
		public List<EnumValue> CircumstancesOfProducings { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Вид документа о расхождениях'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DivergenceDocumentTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Коды операций над документом'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentOperationCodes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Назначение документа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentPurposes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Вид средств'.
		/// </summary>
		[DataMember]
		public List<EnumValue> FundsTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус товарно-транспортной накладной (ТТН)'.
		/// </summary>
		[DataMember]
		public List<EnumValue> GoodsTransportWaybillStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Итоговый результат приемки товара'.
		/// </summary>
		[DataMember]
		public List<EnumValue> GoodsAcceptanceResultTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Роль участника документооборота'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentFlowParticipantRoles { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип заявки на издание сертификата'.
		/// </summary>
		[DataMember]
		public List<EnumValue> CertificateIssueRequestTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус обработки заявки на издание сертификата'.
		/// </summary>
		[DataMember]
		public List<EnumValue> CertificateIssueStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус проверки сертификата'.
		/// </summary>
		[DataMember]
		public List<EnumValue> CertificateValidationStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип провайдера облачной ЭП'.
		/// </summary>
		[DataMember]
		public List<EnumValue> CloudProviderTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус проверки черновика документа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> FormatControlValidationStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус создания усовершенствованной подписи'.
		/// </summary>
		[DataMember]
		public List<EnumValue> EnhancedSignCreateStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Причины неудачной попытки создания усовершенствованной подписи'.
		/// </summary>
		[DataMember]
		public List<EnumValue> EnhancedSignFailedReasons { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип платежа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> PaymentTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип подписанта документа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> SignerTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип суммы налога'.
		/// </summary>
		[DataMember]
		public List<EnumValue> VatAmountTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула водителя (сдача груза) транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillCargoDeliveredTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула перевозчика транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillCarrierTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула изменения места доставки транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillDeliveryPlaceChangeTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула грузополучателя транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillConsigneeTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус транспортной накладной (ТрН)'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула водителя (прием груза) транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillCargoReceivedTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillConsignorTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип участника ЭДО транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillInterchangeParticipantTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип экземпляра транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TransportWaybillCopyTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип авторизации контактов'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ContactAuthTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статусы контакта'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ContactStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Формат содержимого'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ContentFormats { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип функции, которую выполняет документ'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ExecutedFunctions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Признак подписи'.
		/// </summary>
		[DataMember]
		public List<EnumValue> SignatureMarks { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип настройки'.
		/// </summary>
		[DataMember]
		public List<EnumValue> SettingTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус аннулирования документа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentRevocationStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус организации как абонента EDI'.
		/// </summary>
		[DataMember]
		public List<EnumValue> EdiSubscriberStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Список наименований полей, доступных для фильтрации сотрудников'.
		/// </summary>
		[DataMember]
		public List<EnumValue> EmployeeFilterFieldNameLists { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Пол'.
		/// </summary>
		[DataMember]
		public List<EnumValue> Genders { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип документа, удостоверяющего личность'.
		/// </summary>
		[DataMember]
		public List<EnumValue> IdentityDocumentTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус выполнения операции'.
		/// </summary>
		[DataMember]
		public List<EnumValue> OperationStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Режим получения документооборота'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentFlowResultModes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип документооборота (для фильтрации)'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentFlowTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Типы тегов для документа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentTagTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Режим отправки сообщения черновика'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DraftMessageSendModes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип документооборота'.
		/// </summary>
		[DataMember]
		public List<EnumValue> FlowTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус документооборота получателя'.
		/// </summary>
		[DataMember]
		public List<EnumValue> RecipientFlowStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус получения документа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentDeliveryStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус получения документа при отправке нескольким получателям'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentMultiDeliveryStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус подписания документа несколькими получателями'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentMultiSignStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус подписания документа получателем'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentSignStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип документа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> DocumentTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статусы ЭСФ'.
		/// </summary>
		[DataMember]
		public List<EnumValue> InvoiceFlowStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус изменения счета-фактуры'.
		/// </summary>
		[DataMember]
		public List<EnumValue> InvoiceModificationStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус сообщения'.
		/// </summary>
		[DataMember]
		public List<EnumValue> MessageStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Критерии для выборки информации по организации'.
		/// </summary>
		[DataMember]
		public List<EnumValue> OrganizationByCriterias { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус организации в сервисе'.
		/// </summary>
		[DataMember]
		public List<EnumValue> OrganizationStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип организации'.
		/// </summary>
		[DataMember]
		public List<EnumValue> OrganizationTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Код результата регистрации абонента'.
		/// </summary>
		[DataMember]
		public List<EnumValue> RegistrationResponseCodes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус документооборота отправителя'.
		/// </summary>
		[DataMember]
		public List<EnumValue> SenderFlowStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус доступности использования простой ЭП'.
		/// </summary>
		[DataMember]
		public List<EnumValue> SimpleSignatureAvailabilityStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип квалификации подписи'.
		/// </summary>
		[DataMember]
		public List<EnumValue> SignQualificationTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип владельца (субъекта) сертификата'.
		/// </summary>
		[DataMember]
		public List<EnumValue> SubjectPersonTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип документа'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TitleTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Категория сообщения валидации'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ValidationMessageCategories { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Статус сообщения валидации'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ValidationMessageStatuses { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Формат результата валидации'.
		/// </summary>
		[DataMember]
		public List<EnumValue> ValidationResultFormats { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Налоговая ставка'.
		/// </summary>
		[DataMember]
		public List<EnumValue> VatRates { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип оператора составного фильтра'.
		/// </summary>
		[DataMember]
		public List<EnumValue> CompositeFilterOperatorTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип сущности'.
		/// </summary>
		[DataMember]
		public List<EnumValue> EntityTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип значение, представленного простым текстом'.
		/// </summary>
		[DataMember]
		public List<EnumValue> TextValueTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Тип оператора фильтра'.
		/// </summary>
		[DataMember]
		public List<EnumValue> FilterOperatorTypes { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула водителя (прием груза) товарно-транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> GoodsTransportWaybillCargoReceivedTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула водителя (сдача груза) товарно-транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> GoodsTransportWaybillCargoDeliveredTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула грузополучателя товарно-транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> GoodsTransportWaybillConsigneeTitleFormatVersions { get; set; }

		/// <summary>
		/// Значения перечисления типа 'Версия формата титула грузоотправителя товарно-транспортной накладной'.
		/// </summary>
		[DataMember]
		public List<EnumValue> GoodsTransportWaybillConsignorTitleFormatVersions { get; set; }
	}
}