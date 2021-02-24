using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Bakım zamanı";

        public static string ProductCountOfCategoryError = "Ürün sayısı aşıldı.";
        public static string ProductNameAlreadyExist="Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded="Kategori sayısı aşıldı!";
    }
}
