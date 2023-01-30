using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInValid= "Ürün ismi Geçersiz.";
        public static string ProductsListed="Ürünler Listelendi.";
        public static string Maintenancetime="Sistem Bakımda";
        public static string ProductCountOfCategoryError="Kategorideki Ürün Sayısı 10'dan fazla Olamaz.";
        public static string NotAbleToAddSameProductName="Aynı İsimde Ürün Eklenemez.";
    }
}
