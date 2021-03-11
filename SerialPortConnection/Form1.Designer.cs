
namespace ModbusRtu_M7024
{
    partial class ModbusRtu_M7024
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
            this.components = new System.ComponentModel.Container();
            this.cboxPortList = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.richReceived = new System.Windows.Forms.RichTextBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.txtSlaveAdress = new System.Windows.Forms.TextBox();
            this.lblTransmit = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblSlaveA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegiAdress = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxPortList
            // 
            this.cboxPortList.FormattingEnabled = true;
            this.cboxPortList.Location = new System.Drawing.Point(12, 55);
            this.cboxPortList.Name = "cboxPortList";
            this.cboxPortList.Size = new System.Drawing.Size(158, 20);
            this.cboxPortList.TabIndex = 0;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(12, 100);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 36);
            this.btnConn.TabIndex = 1;
            this.btnConn.Text = "연결";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(93, 100);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 36);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "해제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 153);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(53, 12);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "연결상태";
            // 
            // richReceived
            // 
            this.richReceived.Location = new System.Drawing.Point(200, 36);
            this.richReceived.Name = "richReceived";
            this.richReceived.Size = new System.Drawing.Size(357, 100);
            this.richReceived.TabIndex = 4;
            this.richReceived.Text = "";
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Location = new System.Drawing.Point(198, 21);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(29, 12);
            this.lblReceive.TabIndex = 5;
            this.lblReceive.Text = "수신";
            // 
            // txtSlaveAdress
            // 
            this.txtSlaveAdress.Location = new System.Drawing.Point(305, 213);
            this.txtSlaveAdress.Name = "txtSlaveAdress";
            this.txtSlaveAdress.Size = new System.Drawing.Size(138, 21);
            this.txtSlaveAdress.TabIndex = 6;
            // 
            // lblTransmit
            // 
            this.lblTransmit.AutoSize = true;
            this.lblTransmit.Location = new System.Drawing.Point(200, 188);
            this.lblTransmit.Name = "lblTransmit";
            this.lblTransmit.Size = new System.Drawing.Size(29, 12);
            this.lblTransmit.TabIndex = 7;
            this.lblTransmit.Text = "송신";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(474, 265);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(85, 23);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            // 
            // lblSlaveA
            // 
            this.lblSlaveA.AutoSize = true;
            this.lblSlaveA.Location = new System.Drawing.Point(210, 216);
            this.lblSlaveA.Name = "lblSlaveA";
            this.lblSlaveA.Size = new System.Drawing.Size(75, 12);
            this.lblSlaveA.TabIndex = 9;
            this.lblSlaveA.Text = "slaveAdress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(305, 267);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(138, 21);
            this.txtValue.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "registerAddress";
            // 
            // txtRegiAdress
            // 
            this.txtRegiAdress.Location = new System.Drawing.Point(305, 240);
            this.txtRegiAdress.Name = "txtRegiAdress";
            this.txtRegiAdress.Size = new System.Drawing.Size(138, 21);
            this.txtRegiAdress.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 312);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 12);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "ready";
            // 
            // ModbusRtu_M7024
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 349);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegiAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblSlaveA);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lblTransmit);
            this.Controls.Add(this.txtSlaveAdress);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.richReceived);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.cboxPortList);
            this.Name = "ModbusRtu_M7024";
            this.Text = "ModbusRtu_M7024";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxPortList;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.RichTextBox richReceived;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.TextBox txtSlaveAdress;
        private System.Windows.Forms.Label lblTransmit;
        private System.Windows.Forms.Button btnWrite;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblSlaveA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegiAdress;
        private System.Windows.Forms.Label lblStatus;
    }
}

