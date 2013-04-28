namespace Warehouse.Data.Helper
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public static class EncryptionService
    {
        public static string MD5String(string value)
        {
            byte[] originalBytes;
            byte[] encodedBytes;

            using (var md5 = new MD5CryptoServiceProvider())
            {
                originalBytes = Encoding.ASCII.GetBytes(value);
                encodedBytes = md5.ComputeHash(originalBytes);
            }

            return BitConverter.ToString(encodedBytes).Replace("-", String.Empty);
        }
    }
}
