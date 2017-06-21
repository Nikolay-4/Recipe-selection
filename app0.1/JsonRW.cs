using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace app0._1
{

    class JsonRW
    {
        
        //если папка Download содержит >=4 файлов, то используем файлы из этой папки
        static JsonRW()
        {
            string syncFilesPath = Sync.pathToDownloadFolder;
            string folder = "";
            if(Directory.GetFiles(syncFilesPath).Length >= 4)
            {
                folder = syncFilesPath;
            }
            CategoryPath = folder + @"category.json";
            CategoryRecipePath = folder + @"categoryrecipe.json";
            ProductPath = folder + @"product.json";
            RecipePath = folder + @"recipe.json";
        }

        public static string CategoryPath = @"category.json", CategoryRecipePath = @"categoryrecipe.json",
            ProductPath = @"product.json", RecipePath = @"recipe.json";
        public static List<Category> readCategory()
        {
            var arr = new List<Category>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Category>));
            try
            {
                using (FileStream fs = new FileStream(CategoryPath, FileMode.OpenOrCreate))
                {
                    arr = (List<Category>)jsonFormatter.ReadObject(fs);
                }
            }
            catch
            {
                arr = new List<Category>();
            }
            return arr;
        }
        public static bool writeCategory(List<Category> arr)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Category>));
                using (FileStream fs = new FileStream(CategoryPath, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, arr);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static List<CategoryRecipe> readCategoryRecipe()
        {
            var arr = new List<CategoryRecipe>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<CategoryRecipe>));
            try
            {
                using (FileStream fs = new FileStream(CategoryRecipePath, FileMode.OpenOrCreate))
                {
                    arr = (List<CategoryRecipe>)jsonFormatter.ReadObject(fs);
                }
            }
            catch
            {
                arr = new List<CategoryRecipe>();
            }
            return arr;
        }
        public static bool writeCategoryRecipe(List<CategoryRecipe> arr)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<CategoryRecipe>));
                using (FileStream fs = new FileStream(CategoryRecipePath, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, arr);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static List<Product> readProduct()
        {
            var arr = new List<Product>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Product>));
            try
            {
                using (FileStream fs = new FileStream(ProductPath, FileMode.OpenOrCreate))
                {
                    arr = (List<Product>)jsonFormatter.ReadObject(fs);
                }
            }
            catch
            {
                arr = new List<Product>();
            }
            return arr;
        }
        public static bool writeProduct(List<Product> arr)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Product>));
                using (FileStream fs = new FileStream(ProductPath, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, arr);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }


        public static List<Recipe> readRecipe()
        {
            var arr = new List<Recipe>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Recipe>));
            try
            {
                using (FileStream fs = new FileStream(RecipePath, FileMode.OpenOrCreate))
                {
                    arr = (List<Recipe>)jsonFormatter.ReadObject(fs);
                }
            }
            catch
            {
                arr = new List<Recipe>();
            }
            return arr;
        }
        public static bool writeRecipe(List<Recipe> arr)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Recipe>));
                using (FileStream fs = new FileStream(RecipePath, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, arr);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
