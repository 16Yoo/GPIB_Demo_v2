using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ivi.Visa;



namespace GPIB_Demo
{
    public enum eMsgType
    {
        tx,
        rx,
    }


    public class ControlManager
    {
        GpibManager gpibManager;
        //==================================================
        // 생성자
        //==================================================
        public ControlManager()
        {
            gpibManager = new GpibManager();
        }
        //==================================================
        // 장비 검색
        //==================================================
        public Dictionary<uint, DeviceInfo> FindDevice()
        {
            return gpibManager.ConnectGetInfo();
        }
        //==================================================
        // 저장된 장비값으로 상태 확인
        //==================================================
        public Dictionary<uint, DeviceInfo> FindDevice(Dictionary<string, string> saveDeviceValueDic)
        {
            return gpibManager.ConnectGetInfo(saveDeviceValueDic);
        }
        //==================================================
        // 메세지 송신
        //==================================================
        public void SendMsg(string msg, IMessageBasedSession session)
        {
            gpibManager.SendMsg(msg, session);
        }
        //==================================================
        // 메세지 송신 및 수신
        //==================================================
        public string  QueryMsg(string msg, IMessageBasedSession session)
        {
            return gpibManager.QueryMsg(msg, session);
        }
        //==================================================
        // 설정값 저장
        //==================================================
        public static void SaveDeviceSet(Dictionary<string, string> deviceInfo)
        {
            JsonManager.MakeJsonFile(deviceInfo);
        }
        //==================================================
        // 설정값 로드
        //==================================================
        public static Dictionary<string, string> LoadDeviceSet()
        {
           return JsonManager.GetJsonFile();
        }
    }
}
