using System;
using System.Runtime.Serialization;

namespace Midway.ObjectModel
{
    /// <summary>
    /// ���������, ������������ ��� �������� � ������.
    /// </summary>
    [DataContract]
    public class Message : IMessage
    {
        public Message()
        {
            Documents = new Document[0];
            Signs = new Sign[0];
            SimpleSignatures = new SimpleSignature[0];
        }

        /// <summary>
        /// ������������� ���������. 
        /// �� ������������ ��� ��������.
        /// </summary>
        [DataMember]
        public string Id { get; set; }

        /// <summary>
        /// ���� �����������.
        /// ������������ ��� ��������.
        /// </summary>
        [DataMember]
        public string From { get; set; }

        /// <summary>
        /// �� ������������� �����������.
        /// </summary>
        [DataMember]
        public string FromDepartment { get; set; }

        /// <summary>
        /// ���� ����������.
        /// ������������ ��� ��������.
        /// </summary>
        [Obsolete("����������� �������� '" + nameof(Recipients) + "." + nameof(MessageRecipient.OrganizationBoxId) + "'.")]
        [DataMember]
        public string To { get; set; }

        /// <summary>
        /// �� ������������� ����������.
        /// </summary>
        [Obsolete("����������� �������� '" + nameof(Recipients) + "." + nameof(MessageRecipient.DepartmentId) + "'.")]
        [DataMember]
        public string ToDepartment { get; set; }

        /// <summary>
        /// ���������� ���������.
        /// </summary>
        [DataMember]
        public MessageRecipient[] Recipients { get; set; }

        /// <summary>
        /// ����� ������ ���������.
        /// �� ������������ ��� ��������.
        /// </summary>
        [DataMember]
        public DateTime SentDate { get; set; }

        /// <summary>
        /// ���������.
        /// </summary>
        [DataMember]
        public Document[] Documents {get;set;}

        /// <summary>
        /// ��������� �������.
        /// </summary>
        [DataMember]
        public Sign[] Signs { get; set; }

        /// <summary>
        /// ������� �������.
        /// </summary>
        [DataMember]
        public SimpleSignature[] SimpleSignatures { get; set; }
    }
}
