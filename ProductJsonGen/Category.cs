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
    class Category
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        public Category(string name_, int id_ = -1)
        {
            name = name_;
            id = id_;
        }
    }
}
