using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace AddressBookSystem
{
    class Json
    {
        const string JSONPATH = @"C:\Users\Sandeep\Desktop\CSharp\AddressBookSystem\AddressBookSystem\StoredContactJson.json";
        public static void WriteToJson(Dictionary<string, Contact> DictName)
        {
            if (File.Exists(JSONPATH))
            {
                string Json = JsonConvert.SerializeObject(DictName);
                using (StreamWriter sw = new StreamWriter(JSONPATH))
                {
                    sw.WriteLine(Json);
                }
            }
        }
    }
}
