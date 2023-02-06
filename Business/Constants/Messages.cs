using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string AuthorizationDenied = "Yetkiniz yoktur.";
        public static string UserRegistered="Kullanıcı Üye oldu.";
        public static string UserNotFound="Kullanıcı Bulunamadı.";
        public static string PasswordError="Şifreniz Yanlış.";
        public static string SuccessfulLogin= "Kullanıcı Girişi Başarılı";
        public static string UserAlreadyExists="Böyle bir kullanıcı zaten mevcut.";
        public static string AccessTokenCreated="Token Üretildi.";
    }
}
