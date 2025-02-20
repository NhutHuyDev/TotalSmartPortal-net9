using System.Text;
using System.IO;
using System.Security.Cryptography;


namespace TotalCore.Helpers
{
    public static class SecureEncoding
    {
        public static class Global
        {
            // set permutations
            public const String strPermutation = "ouiveyxaqtd";
            public const Int32 bytePermutation1 = 0x19;
            public const Int32 bytePermutation2 = 0x59;
            public const Int32 bytePermutation3 = 0x17;
            public const Int32 bytePermutation4 = 0x41;
        }

        // Encoding
        public static string Encrypt(string strData)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(strData)));
        } // reference https://msdn.microsoft.com/en-us/library/ds4kkd55(v=vs.110).aspx

        // Decoding
        public static string Decrypt(string strData)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(strData)));
        } // reference https://msdn.microsoft.com/en-us/library/system.convert.frombase64string(v=vs.110).aspx

        // Encrypt
        public static byte[] Encrypt(byte[] strData)
        {
            using var aes = Aes.Create();
            using var passbytes = new Rfc2898DeriveBytes(
                Global.strPermutation,
                new byte[] { Global.bytePermutation1, Global.bytePermutation2,
                         Global.bytePermutation3, Global.bytePermutation4 },
                100,
                HashAlgorithmName.SHA256);

            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            using var memstream = new MemoryStream();
            using var cryptostream = new CryptoStream(memstream, aes.CreateEncryptor(), CryptoStreamMode.Write);

            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.FlushFinalBlock();

            return memstream.ToArray();
        }

        // Decrypt
        public static byte[] Decrypt(byte[] strData)
        {
            using var aes = Aes.Create();
            using var passbytes = new Rfc2898DeriveBytes(
                Global.strPermutation,
                new byte[] { Global.bytePermutation1, Global.bytePermutation2, 
                             Global.bytePermutation3, Global.bytePermutation4 },
                100,
                HashAlgorithmName.SHA256);

            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            using var memstream = new MemoryStream();
            using var cryptostream = new CryptoStream(memstream, aes.CreateDecryptor(), CryptoStreamMode.Write);

            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.FlushFinalBlock();

            return memstream.ToArray();
        }

        // Reference
        // https://msdn.microsoft.com/en-us/library/system.security.cryptography(v=vs.110).aspx
        // https://msdn.microsoft.com/en-us/library/system.security.cryptography.cryptostream%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396
        // https://msdn.microsoft.com/en-us/library/system.security.cryptography.rfc2898derivebytes(v=vs.110).aspx
        // https://msdn.microsoft.com/en-us/library/system.security.cryptography.aesmanaged%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396
    }
}
