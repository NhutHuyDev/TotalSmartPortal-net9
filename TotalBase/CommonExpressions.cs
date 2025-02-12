using System.Text.RegularExpressions;
using TotalBase.Enums;

namespace TotalBase
{
    public class CommonExpressions
    {
        /// Loại bỏ các ký tự không phải chữ và số khỏi chuỗi.
        public static string AlphaNumericString(string normalString)
        {
            if (string.IsNullOrEmpty(normalString))
                return string.Empty;

            if (GlobalEnums.DMC)
                return Regex.Replace(normalString, @"[^0-9a-zA-Z.\-*+()]+ ", "");

            return Regex.Replace(normalString, @"[^0-9a-zA-Z.\-*+()]+", "");
        }

        /// Định dạng mã hàng hóa dựa trên loại hàng hóa.
        public static string ComposeCommodityCode(string code, int commodityTypeID)
        {
            code = AlphaNumericString(code);

            if (commodityTypeID != (int)GlobalEnums.CommodityTypeID.Products && code.Length >= 9)
                return code.Substring(0, 5) + "-" + code.Substring(5, 3) + "-" + code.Substring(8, code.Length - 8);
            else
                return code;
        }

        /// Giải mã các ký tự đặc biệt trong URL.
        public static string UrlSpecialLetters(string parameterString)
        {
            if (parameterString.ToUpper() == "NULL")
                parameterString = null;
            
            if (parameterString != null)
                parameterString = parameterString.Replace("!~$76", "/").Replace("!~$77", ":").Replace("!~$78", "*");
            
            return parameterString;
        }
    }
}
