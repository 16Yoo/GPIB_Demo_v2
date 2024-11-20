using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;


namespace GPIB_Demo
{
    public static class JsonManager
    {
        //====================================================================
        // 딕셔너리를 Json으로 저장
        //====================================================================
        public static void MakeJsonFile(Dictionary<string, string> deviceSetInfoDic)
        {
            File.WriteAllText(Application.StartupPath + @"\\Addr.json", JsonConvert.SerializeObject(deviceSetInfoDic));
        }
        //====================================================================
        // Json파일을 딕셔너리로 불러옴
        //====================================================================
        public static Dictionary<string, string> GetJsonFile()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(Application.StartupPath + @"\\Addr.json"));
        }
    }
}
