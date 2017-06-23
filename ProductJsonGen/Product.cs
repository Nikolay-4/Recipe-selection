using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ProductJsonGen
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int category_id { get; set; }

        public Product(string name_, int category_id_, int id_ = -1)
        {
            name = name_;
            category_id = category_id_;
            id = id_;
        }
    }
}
