namespace GPIB_Demo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tlp_Sub = new System.Windows.Forms.TableLayoutPanel();
            this.Tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Tlp_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.Btn_ClearLog = new System.Windows.Forms.Button();
            this.DataGridView_Item = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbox_Log = new System.Windows.Forms.TextBox();
            this.Tlp_sub02 = new System.Windows.Forms.TableLayoutPanel();
            this.Tlp_Sub02_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Query = new System.Windows.Forms.Button();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Cbox_Device = new System.Windows.Forms.ComboBox();
            this.Tbox_msg = new System.Windows.Forms.TextBox();
            this.Tbox_GPIB_Msg = new System.Windows.Forms.TextBox();
            this.Btn_MsgLog_Clear = new System.Windows.Forms.Button();
            this.Tlp_Sub.SuspendLayout();
            this.Tlp_Main.SuspendLayout();
            this.Tlp_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Item)).BeginInit();
            this.Tlp_sub02.SuspendLayout();
            this.Tlp_Sub02_Menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tlp_Sub
            // 
            this.Tlp_Sub.ColumnCount = 1;
            this.Tlp_Sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Sub.Controls.Add(this.Tlp_Main, 0, 0);
            this.Tlp_Sub.Controls.Add(this.Tbox_Log, 0, 1);
            this.Tlp_Sub.Controls.Add(this.Tlp_sub02, 0, 2);
            this.Tlp_Sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Sub.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Sub.Name = "Tlp_Sub";
            this.Tlp_Sub.RowCount = 3;
            this.Tlp_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Tlp_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tlp_Sub.Size = new System.Drawing.Size(925, 561);
            this.Tlp_Sub.TabIndex = 0;
            // 
            // Tlp_Main
            // 
            this.Tlp_Main.ColumnCount = 2;
            this.Tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Tlp_Main.Controls.Add(this.Tlp_Menu, 1, 0);
            this.Tlp_Main.Controls.Add(this.DataGridView_Item, 0, 0);
            this.Tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Main.Location = new System.Drawing.Point(3, 3);
            this.Tlp_Main.Name = "Tlp_Main";
            this.Tlp_Main.RowCount = 1;
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.Tlp_Main.Size = new System.Drawing.Size(919, 330);
            this.Tlp_Main.TabIndex = 0;
            // 
            // Tlp_Menu
            // 
            this.Tlp_Menu.ColumnCount = 1;
            this.Tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Menu.Controls.Add(this.Btn_Set, 0, 1);
            this.Tlp_Menu.Controls.Add(this.Btn_Find, 0, 0);
            this.Tlp_Menu.Controls.Add(this.Btn_ClearLog, 0, 2);
            this.Tlp_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Menu.Location = new System.Drawing.Point(646, 3);
            this.Tlp_Menu.Name = "Tlp_Menu";
            this.Tlp_Menu.RowCount = 3;
            this.Tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_Menu.Size = new System.Drawing.Size(270, 324);
            this.Tlp_Menu.TabIndex = 0;
            // 
            // Btn_Set
            // 
            this.Btn_Set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Set.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Set.Location = new System.Drawing.Point(3, 111);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(264, 102);
            this.Btn_Set.TabIndex = 1;
            this.Btn_Set.Text = "Set";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // Btn_Find
            // 
            this.Btn_Find.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Find.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Find.Location = new System.Drawing.Point(3, 3);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(264, 102);
            this.Btn_Find.TabIndex = 0;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // Btn_ClearLog
            // 
            this.Btn_ClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_ClearLog.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_ClearLog.Location = new System.Drawing.Point(3, 219);
            this.Btn_ClearLog.Name = "Btn_ClearLog";
            this.Btn_ClearLog.Size = new System.Drawing.Size(264, 102);
            this.Btn_ClearLog.TabIndex = 2;
            this.Btn_ClearLog.Text = "Clear Log";
            this.Btn_ClearLog.UseVisualStyleBackColor = true;
            this.Btn_ClearLog.Click += new System.EventHandler(this.Btn_ClearLog_Click);
            // 
            // DataGridView_Item
            // 
            this.DataGridView_Item.AllowUserToAddRows = false;
            this.DataGridView_Item.AllowUserToDeleteRows = false;
            this.DataGridView_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.DataGridView_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Item.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_Item.Name = "DataGridView_Item";
            this.DataGridView_Item.RowTemplate.Height = 23;
            this.DataGridView_Item.Size = new System.Drawing.Size(637, 324);
            this.DataGridView_Item.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Addr";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Online";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Info";
            this.Column4.Name = "Column4";
            // 
            // Tbox_Log
            // 
            this.Tbox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbox_Log.Location = new System.Drawing.Point(3, 339);
            this.Tbox_Log.Multiline = true;
            this.Tbox_Log.Name = "Tbox_Log";
            this.Tbox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbox_Log.Size = new System.Drawing.Size(919, 106);
            this.Tbox_Log.TabIndex = 1;
            // 
            // Tlp_sub02
            // 
            this.Tlp_sub02.ColumnCount = 2;
            this.Tlp_sub02.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Tlp_sub02.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Tlp_sub02.Controls.Add(this.Tlp_Sub02_Menu, 1, 0);
            this.Tlp_sub02.Controls.Add(this.Tbox_GPIB_Msg, 0, 0);
            this.Tlp_sub02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_sub02.Location = new System.Drawing.Point(3, 451);
            this.Tlp_sub02.Name = "Tlp_sub02";
            this.Tlp_sub02.RowCount = 1;
            this.Tlp_sub02.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_sub02.Size = new System.Drawing.Size(919, 107);
            this.Tlp_sub02.TabIndex = 2;
            // 
            // Tlp_Sub02_Menu
            // 
            this.Tlp_Sub02_Menu.ColumnCount = 1;
            this.Tlp_Sub02_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Sub02_Menu.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.Tlp_Sub02_Menu.Controls.Add(this.Cbox_Device, 0, 0);
            this.Tlp_Sub02_Menu.Controls.Add(this.Tbox_msg, 0, 1);
            this.Tlp_Sub02_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Sub02_Menu.Location = new System.Drawing.Point(554, 3);
            this.Tlp_Sub02_Menu.Name = "Tlp_Sub02_Menu";
            this.Tlp_Sub02_Menu.RowCount = 3;
            this.Tlp_Sub02_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_Sub02_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_Sub02_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tlp_Sub02_Menu.Size = new System.Drawing.Size(362, 101);
            this.Tlp_Sub02_Menu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Query, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Send, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_MsgLog_Clear, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Query
            // 
            this.Btn_Query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Query.Location = new System.Drawing.Point(121, 3);
            this.Btn_Query.Name = "Btn_Query";
            this.Btn_Query.Size = new System.Drawing.Size(112, 23);
            this.Btn_Query.TabIndex = 1;
            this.Btn_Query.Text = "Query";
            this.Btn_Query.UseVisualStyleBackColor = true;
            this.Btn_Query.Click += new System.EventHandler(this.Btn_Query_Click);
            // 
            // Btn_Send
            // 
            this.Btn_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Send.Location = new System.Drawing.Point(3, 3);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(112, 23);
            this.Btn_Send.TabIndex = 0;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Cbox_Device
            // 
            this.Cbox_Device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbox_Device.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cbox_Device.FormattingEnabled = true;
            this.Cbox_Device.Location = new System.Drawing.Point(3, 3);
            this.Cbox_Device.Name = "Cbox_Device";
            this.Cbox_Device.Size = new System.Drawing.Size(356, 24);
            this.Cbox_Device.TabIndex = 1;
            // 
            // Tbox_msg
            // 
            this.Tbox_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbox_msg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tbox_msg.Location = new System.Drawing.Point(3, 36);
            this.Tbox_msg.Name = "Tbox_msg";
            this.Tbox_msg.Size = new System.Drawing.Size(356, 26);
            this.Tbox_msg.TabIndex = 2;
            // 
            // Tbox_GPIB_Msg
            // 
            this.Tbox_GPIB_Msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbox_GPIB_Msg.Location = new System.Drawing.Point(3, 3);
            this.Tbox_GPIB_Msg.Multiline = true;
            this.Tbox_GPIB_Msg.Name = "Tbox_GPIB_Msg";
            this.Tbox_GPIB_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbox_GPIB_Msg.Size = new System.Drawing.Size(545, 101);
            this.Tbox_GPIB_Msg.TabIndex = 1;
            // 
            // Btn_MsgLog_Clear
            // 
            this.Btn_MsgLog_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_MsgLog_Clear.Location = new System.Drawing.Point(239, 3);
            this.Btn_MsgLog_Clear.Name = "Btn_MsgLog_Clear";
            this.Btn_MsgLog_Clear.Size = new System.Drawing.Size(114, 23);
            this.Btn_MsgLog_Clear.TabIndex = 2;
            this.Btn_MsgLog_Clear.Text = "Clear";
            this.Btn_MsgLog_Clear.UseVisualStyleBackColor = true;
            this.Btn_MsgLog_Clear.Click += new System.EventHandler(this.Btn_MsgLog_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 561);
            this.Controls.Add(this.Tlp_Sub);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tlp_Sub.ResumeLayout(false);
            this.Tlp_Sub.PerformLayout();
            this.Tlp_Main.ResumeLayout(false);
            this.Tlp_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Item)).EndInit();
            this.Tlp_sub02.ResumeLayout(false);
            this.Tlp_sub02.PerformLayout();
            this.Tlp_Sub02_Menu.ResumeLayout(false);
            this.Tlp_Sub02_Menu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_Sub;
        private System.Windows.Forms.TableLayoutPanel Tlp_Main;
        private System.Windows.Forms.TableLayoutPanel Tlp_Menu;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox Tbox_Log;
        private System.Windows.Forms.Button Btn_ClearLog;
        private System.Windows.Forms.DataGridView DataGridView_Item;
        private System.Windows.Forms.TableLayoutPanel Tlp_sub02;
        private System.Windows.Forms.TableLayoutPanel Tlp_Sub02_Menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Query;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.ComboBox Cbox_Device;
        private System.Windows.Forms.TextBox Tbox_msg;
        private System.Windows.Forms.TextBox Tbox_GPIB_Msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button Btn_MsgLog_Clear;
    }
}

