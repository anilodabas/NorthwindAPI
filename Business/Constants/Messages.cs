using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string CategoryAdded = "Kategori başarıyla eklendi";
        public static string CategoryDelete = "Kategori başarıyla silindi";
        public static string CategoryUpdate = "Kategori başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlReadyExists = "Böyle bir kullancı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";

        public static string AccessTokenCreated = "AccesToken başarıyla oluşturuldu";
    }
}
