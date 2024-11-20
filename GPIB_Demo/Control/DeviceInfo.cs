using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ivi.Visa;

namespace GPIB_Demo
{
    public class DeviceInfo
    {
        //==================================================
        // 다수의 검색된 장비들의 데이타를 보관하기 위한 클래스
        //==================================================
        public DeviceInfo(IMessageBasedSession session, string addr, string info, string onlineStat)
        {
            this.session = session;
            this.addr = addr;
            this.info = info;
            this.onlineStat = onlineStat;
        }
        //==================================================
        // 저장값 로드 장비들의 데이타를 보관하기 위한 클래스
        //==================================================
        public DeviceInfo(IMessageBasedSession session, string addr, string info, string onlineStat, string alias)
        {
            this.session = session;
            this.addr = addr;
            this.info = info;
            this.onlineStat = onlineStat;
            this.alias = alias;
        }


        public IMessageBasedSession session = null;
        public string addr = string.Empty;
        public string info = string.Empty;
        public string onlineStat = string.Empty;
        public string alias = string.Empty;
    }
}
