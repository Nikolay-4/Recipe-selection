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
    public class Recipe
    {
        [DataMember]
        public int id;

        [DataMember]
        public string name;

        [DataMember]
        public string description;

        [DataMember]
        public string preview;

        [DataMember]
        public double caloricity;

        [DataMember]
        public List<string> products;

        [DataMember]
        public List<double> productsCnt;

        [DataMember]
        public List<string> productsUnit;

        [DataMember]
        public List<string> categories;

        [DataMember]
        public int number;

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
