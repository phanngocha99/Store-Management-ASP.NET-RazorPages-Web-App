using StoreManagement.Data;
using StoreManagement.Entities;

namespace StoreManagement.Logic
{
    public class Category_Logic
    {
        public static Category[]? FindCategoriesByName(string keySearch)
        {
            Category[] listCategories = Category_Data.ReadListCategory();
            int numberCategoriesContainsKeySearch = 0;

            for (int i = 0; i < listCategories.Length; i++)
            {
                if (listCategories[i].Name.Contains(keySearch))
                {
                    numberCategoriesContainsKeySearch++;
                }
            }

            Category[]? result = new Category[numberCategoriesContainsKeySearch];
            int j = 0;
            if (numberCategoriesContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberCategoriesContainsKeySearch; i++)
                {
                    if (listCategories[i].Name.Contains(keySearch))
                    {
                        result[j] = listCategories[i];
                        j++;
                    }
                }
            }
            return result;
        }



        public static bool IsNotValidString(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return true;
            }
            return false;
        }

        public static bool IsNotUniqueCategoryName(string categoryName)
        {
            Category[] listCategories = Category_Data.ReadListCategory();

            for (int i = 0; i < listCategories.Length; i++)
            {
                if (categoryName == listCategories[i].Name)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool AddCategory(Category newCategory)
        {
            Category[] listCatories = Category_Data.ReadListCategory();
            Category[] newListCategories = new Category[listCatories.Length + 1];

            for (int i = 0; i < listCatories.Length; i++)
            {
                newListCategories[i] = listCatories[i];
            }
            newListCategories[listCatories.Length] = newCategory;

            const string path = "\\Files\\Category.txt";
            Category_Data.SaveCategories(path, newListCategories);

            return true;
        }

        public static Category FindCategoryByName(string categoryName)
        {
            Category[] listCategories = Category_Data.ReadListCategory();
            Category result = new Category();

            for (int i = 0; i < listCategories.Length; i++)
            {
                if (listCategories[i].Name.Equals(categoryName))
                {
                    result = listCategories[i];
                    return result;
                }
            }
            return result;
        }

        public static Category FindCategoryById(string categoryId)
        {
            Category[] listCategories = Category_Data.ReadListCategory();
            Category result = new Category();

            for (int i = 0; i < listCategories.Length; i++)
            {
                if (listCategories[i].Id.ToString().Equals(categoryId))
                {
                    result = listCategories[i];
                    return result;
                }
            }
            return result;
        }

        public static Category? EditCategory(string categoryId, string categoryName, string newEditCategoryId, string newEditCategoryName)
        {
            Category[] listCategories = Category_Data.ReadListCategory();
            Category? result = null;

            for (int i = 0; i < listCategories.Length; i++)
            {
                if (listCategories[i].Id.ToString().Equals(categoryId))
                {
                    listCategories[i].Name = newEditCategoryName;
                    listCategories[i].Id = int.Parse(newEditCategoryId);
                    result = listCategories[i];
                }
            }

            const string path = "\\Files\\Category.txt";
            Category_Data.SaveCategories(path, listCategories);
            Product_Logic.UpdateListProductsByCategory(categoryName,newEditCategoryName);

            return result;
        }

        public static Category[]? FindCategoriesById(string keySearch)
        {
            Category[] listCategories = Category_Data.ReadListCategory();
            int numberContainsKeySearch = 0;

            for (int i = 0; i < listCategories.Length; i++)
            {
                if (listCategories[i].Id.ToString().Contains(keySearch))
                {
                    numberContainsKeySearch++;
                }
            }

            Category[]? result = new Category[numberContainsKeySearch];
            int j = 0;
            if (numberContainsKeySearch == 0)
            {
                result = null;
            }
            else
            {
                for (int i = 0; i < numberContainsKeySearch; i++)
                {
                    if (listCategories[i].Id.ToString().Contains(keySearch))
                    {
                        result[j] = listCategories[i];
                        j++;
                    }
                }
            }
            return result;
        }

        public static bool IsNotValidNumber(int isNotValidNumberd)
        {
            if (isNotValidNumberd < 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsNotUniqueId(int Id)
        {
            Category[] lists = Category_Data.ReadListCategory();

            for (int i = 0; i < lists.Length; i++)
            {
                if (Id == lists[i].Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsNotContainBlankSpaceProductId(string Id)
        {
            return Id.Contains(" ");
        }

        public static bool DeleteCategory(int deleteId)
        {
            Category[] listCategories = Category_Data.ReadListCategory();
            Category[] newListCategories = new Category[listCategories.Length - 1];
            string deleteCategory = "";

            int j = 0;
            for (int i = 0; i < listCategories.Length; i++)
            {
                if (deleteId != listCategories[i].Id)
                {
                    newListCategories[j] = listCategories[i];
                    j++;
                } else
                {
                    deleteCategory = listCategories[i].Name; 
                }
            }

            const string path = "\\Files\\Category.txt";
            Category_Data.SaveCategories(path, newListCategories);
            Product_Logic.DeleteProductsByCategory(deleteCategory);

            return true;

        }
    }
}
