using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApplication.App_Start
{
    public static class stringHelper
    {
        public static string GenerateURL(this string Title)
        {
            if (string.IsNullOrEmpty(Title))
                return "";
            Title = ToAscii(Title);
            string strTitle = Title.ToString();

            //#region Generate SEO Friendly URL based on Title

            strTitle = strTitle.Trim();
            strTitle = strTitle.Trim('-');

            strTitle = strTitle.ToLower();
            char[] chars = @"$%#@!*?;:~`+=()[]{}|\'<>,/^&"".".ToCharArray();
            strTitle = strTitle.Replace("c#", "C-Sharp");
            strTitle = strTitle.Replace("vb.net", "VB-Net");
            strTitle = strTitle.Replace("asp.net", "Asp-Net");
            strTitle = strTitle.Replace(".", "-");
            for (int i = 0; i < chars.Length; i++)
            {
                string strChar = chars.GetValue(i).ToString();
                if (strTitle.Contains(strChar))
                {
                    strTitle = strTitle.Replace(strChar, string.Empty);
                }
            }
            strTitle = strTitle.Replace(" ", "-");

            strTitle = strTitle.Replace("--", "-");
            strTitle = strTitle.Replace("---", "-");
            strTitle = strTitle.Replace("----", "-");
            strTitle = strTitle.Replace("-----", "-");
            strTitle = strTitle.Replace("----", "-");
            strTitle = strTitle.Replace("---", "-");
            strTitle = strTitle.Replace("--", "-");
            strTitle = strTitle.Trim();

            return strTitle;
        }

        public static String ToAscii(this String unicode)
        {
            unicode = unicode.ToLower();
            unicode = Regex.Replace(unicode, "[áàảãạăắằẳẵặâấầẩẫậ]", "a");
            unicode = Regex.Replace(unicode, "[óòỏõọôồốổỗộơớờởỡợ]", "o");
            unicode = Regex.Replace(unicode, "[éèẻẽẹêếềểễệ]", "e");
            unicode = Regex.Replace(unicode, "[íìỉĩịIÍĨÌỈĨ]", "i");
            unicode = Regex.Replace(unicode, "[úùủũụưứừửữự]", "u");
            unicode = Regex.Replace(unicode, "[ýỳỷỹỵ]", "y");
            unicode = Regex.Replace(unicode, "[đ]", "d");
            //unicode = Regex.Replace(unicode, "[-\\s+/]+", "-");
            unicode = Regex.Replace(unicode, "\\W+", "-");
            //Nếu bạn muốn thay dấu khoảng trắng thành dấu "_" hoặc dấu cách " " thì thay kí tự bạn muốn vào đấu "-"
            return unicode;
        }
    }
}