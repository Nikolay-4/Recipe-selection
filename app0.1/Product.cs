using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace app0._1
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        [DataMember]
        public int category_id;

        public Product(string name_, int category_id_, int id_ = -1)
        {
            name = name_;
            category_id = category_id_;
            id = id_;
        }
    }
}
