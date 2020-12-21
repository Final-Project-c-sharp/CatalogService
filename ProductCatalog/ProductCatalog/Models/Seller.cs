using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace ProductCatalog.Models
{
    [DataContract]
    public class Seller
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public float Salary { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int SecurityLvl { get; set; }
        public override string ToString()
        {
            return $" {Name} {SurName} -> Age: {Age}, Phone: {PhoneNumber}, Salary: {Salary}$";
        }
    }
}
