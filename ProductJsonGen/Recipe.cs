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
    class Recipe
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public string preview { get; set; }

        [DataMember]
        public double caloricity { get; set; }

        [DataMember]
        public List<string> products { get; set; }

        [DataMember]
        public List<double> productsCnt { get; set; }

        [DataMember]
        public List<string> productsUnit { get; set; }

        [DataMember]
        public List<string> categories { get; set; }

        [DataMember]
        public int number { get; set; }

        public Recipe(string name_, string description_, string preview_, int number_,
            List<string> products_, List<double> productsCnt_, List<string> productsUnit_,
            double caloricity_, List<string> categories_, int id_ = -1)
        {
            id = id_;
            name = name_;
            description = description_;
            products = products_;
            productsCnt = productsCnt_;
            productsUnit = productsUnit_;

            caloricity = caloricity_;
            categories = categories_;
            preview = preview_;

            number = number_;
        }
    }
}
