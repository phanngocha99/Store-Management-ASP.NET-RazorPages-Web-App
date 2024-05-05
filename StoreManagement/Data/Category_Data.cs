using StoreManagement.Entities;

namespace StoreManagement.Data
{
    public class Category_Data
    {
        public static Category[] ReadListCategory()
        {
            Category[] listCategories;
            string[] lines;
            string[] category;
            int categoryNumber = 0;

            const string path = "\\Files\\Category.txt";
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamReader file = new StreamReader(filepath);
            lines = file.ReadToEnd().Split(new char[] { '\n' });
            file.Close();

            for (int i = 0; i < lines.Length; i++)
            {
                category = lines[i].Split(",");
                if (!string.IsNullOrEmpty(category[0]))
                {
                    categoryNumber++;
                }
            }

            listCategories = new Category[categoryNumber];

            for (int i = 0; i < categoryNumber; i++)
            {
                category = lines[i].Split(",");
                if (!string.IsNullOrEmpty(category[0]))
                {
                    listCategories[i].Id = int.Parse(category[0]);
                    listCategories[i].Name = category[1];
                    listCategories[i].Quantity = int.Parse(category[2]);
                }
            }

            return listCategories;
        }

        public static void SaveCategories(string path, Category[] listCategories)
        {
            string? dir = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filepath = dir + path;
            StreamWriter file = new StreamWriter(filepath);
            string categoryId;
            string categoryName;
            string categoryQuantity;
            string line;
            for (int i = 0; i < listCategories.Length; i++)
            {
                categoryId = listCategories[i].Id.ToString();
                categoryName = listCategories[i].Name;
                categoryQuantity = listCategories[i].Quantity.ToString();
                line = categoryId + "," + categoryName + "," + categoryQuantity;
                file.WriteLine(line);
            }
            file.Close();
        }
    }
}
