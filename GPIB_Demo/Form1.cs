using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ivi.Visa;


namespace GPIB_Demo
{
    public partial class Form1 : Form
    {
        ControlManager controlManager;
        Dictionary<uint, DeviceInfo> deviceInfoDic;
        Dictionary<string, string> deviceInfoSetDic = new Dictionary<string, string>();
        Dictionary<string, IMessageBasedSession> deviceControlDic = new Dictionary<string, IMessageBasedSession>();

     
        public Form1()
        {
            InitializeComponent();
            Init();
            DataGridViewInit();
            LoadDeviceInfo();
        }
        //==========================================================
        //  초기화
        //==========================================================
        void Init()
        {
            Btn_Set.Enabled = false;

            controlManager = new ControlManager();
        }
        //==========================================================
        //  장비 데이타 로드
        //==========================================================
        void LoadDeviceInfo()
        {
            DataGridView_Item.Rows.Clear();

            try
            {
                deviceInfoDic = controlManager.FindDevice(ControlManager.LoadDeviceSet());

                if (deviceInfoDic.Count < 1)
                {
                    MessageBox.Show("GPIB 리소스 로드 오류", "리소스 로드 오류");
                    LogUpdate("장비 로드 실패");

                    return;
                }

                for (uint i = 1; i <= deviceInfoDic.Count; i++)
                {
                    DataGridView_Item.Rows.Add(i, deviceInfoDic[i].alias, deviceInfoDic[i].addr, deviceInfoDic[i].onlineStat, deviceInfoDic[i].info);
                }

                LogUpdate("장비 로드 완료");
                Btn_Set.Enabled = true;
            }
            catch (Exception es)
            {
                MessageBox.Show("GPIB 리소스 로드 오류", "리소스 로드 오류");
                LogUpdate("장비 로드 실패");
            }
        }
        //==========================================================
        // DataGridView 초기화
        //==========================================================
        void DataGridViewInit()
        {
            DataGridView_Item.Columns[0].ReadOnly = true;
            DataGridView_Item.Columns[2].ReadOnly = true;
            DataGridView_Item.Columns[3].ReadOnly = true;
            DataGridView_Item.Columns[4].ReadOnly = true;
        }
        //==========================================================
        // 장비 검색
        //==========================================================
        private void Btn_Find_Click(object sender, EventArgs e)
        {
            DataGridView_Item.Rows.Clear();

            try
            {
                deviceInfoDic = controlManager.FindDevice();

                if(deviceInfoDic.Count <1 )
                {
                    MessageBox.Show("GPIB 리소스 검색 오류", "리소스 검색 오류");
                    LogUpdate("장비 검색 실패");

                    return;
                }

                for (uint i = 1; i <= deviceInfoDic.Count; i++)
                {
                    DataGridView_Item.Rows.Add(i, "", deviceInfoDic[i].addr, deviceInfoDic[i].onlineStat, deviceInfoDic[i].info);
                }

                LogUpdate("장비 검색 완료");
                Btn_Set.Enabled = true;
            }
            catch(Exception es)
            {
                MessageBox.Show("GPIB 리소스 검색 오류", "리소스 검색 오류");
                LogUpdate("장비 검색 실패");
            }
        }
        //==========================================================
        // 장비를 별칭으로 연결
        //==========================================================
        private void Btn_Set_Click(object sender, EventArgs e)
        {
            bool isEmpty = false;
            deviceInfoSetDic.Clear();
            deviceControlDic.Clear();

            //----------------------------------------------------------
            // 검색된 장비 없을때 진행 안되도록
            //----------------------------------------------------------
            if (deviceInfoDic.Count < 1)
            {
                MessageBox.Show("장비 검색을 먼저 해주세요", "장비 등록 순서 오류");
                return;
            }
            //----------------------------------------------------------
            // 검색 장비에 별칭 입력 안했을때 진행 안되도록
            //----------------------------------------------------------
            for (int i = 0; i < DataGridView_Item.Rows.Count; i++)
            {
                if (DataGridView_Item.Rows[i].Cells[1].Value.ToString() == "")
                    isEmpty = true;
            }

            if (isEmpty)
            {

                MessageBox.Show("장비 별칭을 입력해주세요", "장비 별칭 등록 오류");
                return;
            }
            //==========================================================


            uint idx = 1;

            try
            {
                for (int i = 0; i < DataGridView_Item.Rows.Count; i++)
                {
                    uint.TryParse(DataGridView_Item.Rows[i].Cells[0].Value.ToString(), out idx);
                    deviceInfoSetDic.Add(DataGridView_Item.Rows[i].Cells[1].Value.ToString(), deviceInfoDic[idx].addr);

                    DataGridView_Item.Rows[i].Cells[1].Value.ToString();

                    deviceControlDic.Add(DataGridView_Item.Rows[i].Cells[1].Value.ToString(), deviceInfoDic[idx].session);

                    ControlManager.SaveDeviceSet(deviceInfoSetDic);
                    LogUpdate($"{DataGridView_Item.Rows[i].Cells[1].Value.ToString()} 장비 등록 완료");


                    Cbox_Device.Items.Add(DataGridView_Item.Rows[i].Cells[1].Value.ToString());
                }
            }
            catch (Exception es)
            {
                LogUpdate("장비 등록 실패");
            }
        }
        //==========================================================
        // 로그창 클리어
        //==========================================================
        private void Btn_ClearLog_Click(object sender, EventArgs e)
        {
            Tbox_Log.Clear();
        }
        //==========================================================
        // 로그창 업데이트
        //==========================================================
        void LogUpdate(string msg)
        {
            Tbox_Log.AppendText($"{DateTime.Now.ToString("yy-MM-dd hh:mm:ss")}  {msg}" + Environment.NewLine);
        }
        //==========================================================
        // 메세지창 업데이트
        //==========================================================
        void MsgLogUpdate(string msg, eMsgType eMsgType)
        {
            Tbox_GPIB_Msg.AppendText($"{DateTime.Now.ToString("yy-MM-dd hh:mm:ss")}  {eMsgType}: {msg}" + Environment.NewLine);
        }
        //==========================================================
        // 메세지 송신 버튼
        //==========================================================
        private void Btn_Send_Click(object sender, EventArgs e)
        {
            controlManager.SendMsg(Tbox_msg.Text, deviceControlDic[Cbox_Device.SelectedItem.ToString()]);
            MsgLogUpdate(Tbox_msg.Text, eMsgType.tx);
        }
        //==========================================================
        // 메세지 쿼리 버튼
        //==========================================================
        private void Btn_Query_Click(object sender, EventArgs e)
        {
            MsgLogUpdate(Tbox_msg.Text, eMsgType.tx);
            string  receivedMsg = controlManager.QueryMsg(Tbox_msg.Text, deviceControlDic[Cbox_Device.SelectedItem.ToString()]);
            MsgLogUpdate(receivedMsg, eMsgType.rx);
        }
        //==========================================================
        // 메세지창 클리어
        //==========================================================
        private void Btn_MsgLog_Clear_Click(object sender, EventArgs e)
        {
            Tbox_msg.Clear();
        }
    }
}
