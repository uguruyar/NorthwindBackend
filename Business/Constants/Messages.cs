using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Product Added Successfully";
        public static string ProductUpdated = "Product Updated Successfully";
        public static string ProductDeleted = "Product Deleted Successfully";

        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Password wrong.";
        public static string SuccessfulLogin = "Login Successful";
        public static string UserAlreadyExists = "User Already Exists";
        public static string UserRegistered = "User Created Successfully";
        public static string AccessTokenCreated = "Access Token Created Successfully";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut.";
    }
}
