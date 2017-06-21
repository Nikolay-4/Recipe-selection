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
    class CategoryRecipe
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        public CategoryRecipe(string name_, int id_ = -1)
        {
            name = name_;
            id = id_;
        }
    }
}
