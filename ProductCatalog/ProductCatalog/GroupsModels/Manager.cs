using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace ProductCatalog.GroupsModels
{
    [DataContract]
    class Manager
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
