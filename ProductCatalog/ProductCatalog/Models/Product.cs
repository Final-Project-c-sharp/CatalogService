using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace ProductCatalog.Models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Producer { get; set; }
        [DataMember]
        public float Price { get; set; }
        [DataMember]
        public int Count { get; set; }
        public override string ToString()
        {
            return $" {Name}  Producer: \"{Producer}\" -> {Price}$, count -> {Count} ";
        }

    }
}
