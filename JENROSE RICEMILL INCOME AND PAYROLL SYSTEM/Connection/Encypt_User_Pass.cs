using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace JENROSE_RICEMILL_INCOME_AND_PAYROLL_SYSTEM
{
    class Encypt_User_Pass
    {
        public string GetEncrypt(string pass)
        {
            MD5CryptoServiceProvider cyptedMDS = new MD5CryptoServiceProvider();
            cyptedMDS.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] result = cyptedMDS.Hash;
            StringBuilder str = new StringBuilder();

            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }
    }
}
