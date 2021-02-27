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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten baska bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti asildigi icin yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserRegistered = "Kullanici kayit oldu";
        internal static string UserNotFound = "Kullanici bulunamadi";
        internal static string PasswordError = "Hatali parola";
        internal static string SuccessfulLogin = "Giris basarili";
        internal static string UserAlreadyExists = "Kullanici zaten var";
        internal static string AccessTokenCreated = "Token olusturuldu";
    }
}
