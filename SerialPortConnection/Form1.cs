using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using Modbus.Device;

namespace ModbusRtu_M7024
{
    public partial class ModbusRtu_M7024 : Form
    {
        private static SerialPort port;
        private static ModbusSerialMaster master;

        public ModbusRtu_M7024()
        {
            InitializeComponent();
            try
            {
                port = new SerialPort();
                
                cboxPortList.DataSource = SerialPort.GetPortNames(); //PortName dataSource 지정
                
            }
            catch(Exception ex)
            {
                lblStatus.Text = ex.Message;
            }            

        }

        private void btnConn_Click(object sender, EventArgs e) //포트연결
        {
            if (!port.IsOpen)
            {
                try
                {

                    PortSetting(); //포트정보세팅

                    //port.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived); //데이터 수신이벤트 등록

                    port.Open(); //포트열기

                    MasterSetting();
                    
                    lblState.Text = "포트가 열렸습니다.";
                   
                    cboxPortList.Enabled = false; //콤보박스 비활성화
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
                }
            }
            else
            {
                lblState.Text = "포트가 이미 열려있습니다.";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) //포트 연결해제
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                    lblState.Text = "포트가 해제되었습니다.";
                    cboxPortList.Enabled = true; //콤보박스 활성화
                }
                else
                {
                    lblState.Text = "포트가 이미 닫혀있습니다.";
                }

            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void PortSetting()
        {
            try
            {
                port.PortName = cboxPortList.Text;
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
            }
            catch(Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
            
        }

        private void MasterSetting()
        {
            try
            {
                master = ModbusSerialMaster.CreateRtu(port);
                //master.Transport.Retries = 0;
                //master.Transport.ReadTimeout = 300; //milliseconds
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (txtRegiAdress.Text != "" && txtSlaveAdress.Text != "" && txtValue.Text != "")
            {
                MasterWrite();
            }
        }

        private void MasterWrite()
        {
            
            try
            {
                byte slaveAddress = Convert.ToByte(txtSlaveAdress.Text);
                ushort registerAddress = Convert.ToUInt16(txtRegiAdress.Text); //ex)40003->3
                ushort value = Convert.ToUInt16(txtValue.Text); //0~10V : 0~10000

                master.WriteSingleRegister(slaveAddress, registerAddress, value);
                lblStatus.Text = "master write";

            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        /*
        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(portReceived)); //쓰레드 충돌을 막기위한 delegate
        }
        private void portReceived(object s, EventArgs e) //데이터 처리함수
        {
            //데이터처리
            int ReceiveData = port.ReadByte();
            richReceived.Text = richReceived.Text + string.Format("{0:X2}", ReceiveData);
            
        }
        */
    }

}
