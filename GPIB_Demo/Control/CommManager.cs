using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ivi.Visa;


namespace GPIB_Demo
{
    public class CommManager
    {
        //================================================================
        // 장비 리소스 확인
        //================================================================
        public IEnumerable<String> FindGpibRsc()
        {
           return GlobalResourceManager.Find("GPIB?*INSTR");
        }
        //================================================================
        // 장비 연결
        //================================================================
        public IMessageBasedSession Connect(string addr)
        {
            return (IMessageBasedSession)GlobalResourceManager.Open(addr);
        }
        //================================================================
        // SCPI 명령어 전송
        //================================================================ㅊ
        public void SendMsg(string msg, IMessageBasedSession session)
        {
            session.FormattedIO.WriteLine(msg);
        }
        //================================================================
        // SCPI 명령어 전송 및 수신
        //================================================================
        public string QueryMsg(string msg, IMessageBasedSession session)
        {
            session.FormattedIO.WriteLine(msg);
            return session.FormattedIO.ReadLine();
        }

    }
}
