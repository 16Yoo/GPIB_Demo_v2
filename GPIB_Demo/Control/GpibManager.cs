using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ivi.Visa;

namespace GPIB_Demo
{
    public class GpibManager
    {
        CommManager commManager;
        Dictionary<uint, DeviceInfo> deviceInfoDic = new Dictionary<uint, DeviceInfo>();

        public GpibManager()
        {
            commManager = new CommManager();
        }
        //==================================================
        // 장비 연결하고 정보를 받아오는 메서드
        //==================================================
        public Dictionary<uint, DeviceInfo> ConnectGetInfo()
        {
            uint index = 1;

            //장비 검색시 세션 리스트내부 세션정보, Datagridview 초기화

            deviceInfoDic.Clear();
            try
            {
                List<string> deviceList = commManager.FindGpibRsc().ToList();                   //GPIB 장비 검색 

                foreach (var item in deviceList)
                {
                    IMessageBasedSession session = (IMessageBasedSession)GlobalResourceManager.Open(item);   //앞에서 검색된 주소값을 통해 장비 정보 확인
                    session.FormattedIO.WriteLine("*IDN?");
                    string receivedData = session.FormattedIO.ReadLine();

                    DeviceInfo deviceInfo = new DeviceInfo(session, item, receivedData, receivedData.Length>0? "Online" : "Offline");

                    deviceInfoDic.Add(index, deviceInfo);                                                         //세션 정보를 클래스 리스트에 입력

                    index++;
                }
            }
            catch (Exception es)
            {
             
            }

            return deviceInfoDic;
        }
        //==================================================
        // 저장된 정보값을 기준으로 정보를 받아오는 메서드
        //==================================================
        public Dictionary<uint, DeviceInfo> ConnectGetInfo(Dictionary<string, string> saveValueDic)
        {
            uint index = 1;

            //장비 검색시 세션 리스트내부 세션정보, Datagridview 초기화

            deviceInfoDic.Clear();
            try
            {
              

                foreach (var item in saveValueDic)
                {
                    IMessageBasedSession session = (IMessageBasedSession)GlobalResourceManager.Open(item.Value);   //주소값을 통해 장비 정보 확인
                    session.FormattedIO.WriteLine("*IDN?");
                    string receivedData = session.FormattedIO.ReadLine();

                    DeviceInfo deviceInfo = new DeviceInfo(session, item.Value, receivedData, receivedData.Length > 0 ? "Online" : "Offline", item.Key);

                    deviceInfoDic.Add(index, deviceInfo);                                                         //세션 정보를 클래스 리스트에 입력

                    index++;
                }
            }
            catch (Exception es)
            {

            }

            return deviceInfoDic;
        }
        //==================================================
        // 송신 메서드
        //==================================================
        public void SendMsg(string  msg, IMessageBasedSession session)
        {
            commManager.SendMsg(msg, session);
        }
        //==================================================
        // 송수신 메서드
        //==================================================
        public string QueryMsg(string msg, IMessageBasedSession session)
        {
            return commManager.QueryMsg(msg, session);
        }
    }
}
