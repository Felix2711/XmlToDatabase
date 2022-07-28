using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XmlToDatabase.Config
{
    public class Config
    {
        public static string GetConnectionString()
        {
            switch (Environment.GetEnvironmentVariable("OO_Developer"))
            {
                default:
                    return "";
            }
        }
    }
}
