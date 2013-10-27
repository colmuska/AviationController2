using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace AviationController2
{
    public partial class AviationController : Form
    {
        JoypadController joypadController;

        List<string> commandLog;

        int commandLogIndex;
        FileStream fileStream;
        StreamReader fileReader;

        List<double>[] pos;
        List<double>[] speed;
        List<double>[] gpsPos;
        double pitch;
        double heading;
        double role;

        object syncObject = new object();

        static int LIST_LENGTH_LIMIT=10000;   //100Hz * 10 min
        static int LOG_TEXT_LINE_LENGTH_LIMIT = 10000;

        public AviationController()
        {
            InitializeComponent();

            updateSerialPortSelector();
            updateJoypadSelector();

            commandLog = new List<string>();
            commandLog.Add("");
            commandLogIndex = 0;

            pos = new List<double>[3];
            speed = new List<double>[3];
            gpsPos = new List<double>[3];
            for (int i = 0; i < 3; i++)
            {
                pos[i] = new List<double>();
                speed[i] = new List<double>();
                gpsPos[i] = new List<double>();
            }



        }

        private void AviationController_Load(object sender, EventArgs e)
        {
            comboBoxScaleXY.SelectedIndex = 0;
            comboBoxScaleZ.SelectedIndex = 0;

            

            //for debug.
            try
            {
                comboBoxSerialPort.SelectedIndex = 2;
                tabControl1.SelectedIndex = 1;
                button1_Click(null, null);
            }
            catch (Exception)
            {
                comboBoxSerialPort.SelectedIndex = 0;
            }
            
        }

        private void updateSerialPortSelector()
        {
            comboBoxSerialPort.Items.Clear();
            string[] portNames = SerialPort.GetPortNames();
            comboBoxSerialPort.Items.Add("---");
            for (int i = 0; i < portNames.Length; i++)
            {
                comboBoxSerialPort.Items.Add(portNames[i]);
            }
            comboBoxSerialPort.SelectedIndex = 0;
        }
        private void updateJoypadSelector()
        {
            comboBoxJoypad.Items.Clear();
            string[] joypadNames = JoypadController.getJoypadList();

            for (int i = 0; i < joypadNames.Length; i++)
            {
                comboBoxJoypad.Items.Add(joypadNames[i]);
            }
            if (0 < joypadNames.Length)
            {
                comboBoxJoypad.SelectedIndex = 0;
            }
        }

        delegate void page2PanelDelegate();

        private void updateView()
        {
            BeginInvoke(new page2PanelDelegate(page2Panel.Refresh), null);
            //page2Panel.Refresh();
            
        }

        private void updateJoyView()
        {
            trackBarJoyPitch.Value = 255 - joypadController.getPitch();
            trackBarJoyRole.Value = joypadController.getRole();
            trackBarJoyYaw.Value = 255 - joypadController.getYaw();
            trackBarJoyThrottle.Value = joypadController.getThrottle();
            trackBarJoyFlaps.Value = joypadController.getFlaps();
        }

        private void sendJoyState()
        {
            if (serialPort1.IsOpen)
            {
                int pitch = joypadController.getPitch();
                int role = joypadController.getRole();
                int yaw = joypadController.getYaw();
                int throttle = joypadController.getThrottle();
                int flaps = joypadController.getFlaps();

                serialPort1.Write("setservo "+pitch.ToString("x2")+","+role.ToString("x2")+","
                    +yaw.ToString("x2")+","+throttle.ToString("x2")+","+flaps.ToString("x2")+"\r");
            }
        }



        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            joypadController.updateJoyState();

            updateJoyView();
            sendJoyState();

        }

        /// <summary>
        /// serial port section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            if (comboBoxSerialPort.SelectedIndex != 0)
            {
                try
                {
                    serialPort1.PortName = (string)comboBoxSerialPort.Items[comboBoxSerialPort.SelectedIndex];
                    serialPort1.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("cannot open " + comboBoxSerialPort.Items[comboBoxSerialPort.SelectedIndex]);
                    comboBoxSerialPort.SelectedIndex = 0;
                }
            }

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (true)
                {
                    string line = serialPort1.ReadLine();
                    handleReceivedLine(line);
                }
            }

            catch (TimeoutException)
            {
            }
            catch (IOException)
            {
            }
            catch (InvalidOperationException)
            {
            }
            
        }

        private void decodeLine(string line)
        {

            line = System.Text.RegularExpressions.Regex.Replace(line, "[^\\-\\.0-9,]", "");
            string[] splited = line.Split(',');

            if (splited.Length == 19)//heading,pitch,role,aclX,aclY,aclZ,gyroX,gyroY,gyroZ,cmpsX,cmpsY,cmpsZ,spdX,spdY,spdZ,posX,posY,posZ,
            {
                pitch=double.Parse(splited[1]);
                role = double.Parse(splited[2]);
                heading=double.Parse(splited[0]);

                for (int i = 0; i < 3; i++)
                {
                    pos[i].Add(double.Parse(splited[15 + i]));
                    speed[i].Add(double.Parse(splited[12 + i]));
                }
            }
            else if (splited.Length == 21)
            {
                pitch = double.Parse(splited[1]);
                role = double.Parse(splited[2]);
                heading = double.Parse(splited[0]);

                for (int i = 0; i < 3; i++)
                {
                    pos[i].Add(double.Parse(splited[15 + i]));
                    speed[i].Add(double.Parse(splited[12 + i]));
                }
                gpsPos[0].Add(double.Parse(splited[18]));
                gpsPos[1].Add(double.Parse(splited[19]));
                gpsPos[2].Add(double.Parse(splited[19]));
            }

            if (LIST_LENGTH_LIMIT < pos[0].Count)
            {
                for (int i = 0; i < 3; i++)
                {
                    pos[i].RemoveAt(0);
                    speed[i].RemoveAt(0);
                    gpsPos[i].RemoveAt(0);
                }
            }
        }

        delegate void textBoxDelegate(string line);
        delegate void textBoxRemoveDelegate();

        private void handleReceivedLine(string line)
        {
            object[] args = { line + "\n" };
            BeginInvoke(new textBoxDelegate(logTextBox.AppendText), args);

            
            if (LOG_TEXT_LINE_LENGTH_LIMIT < logTextBox.Lines.Length)
            {
                BeginInvoke(new textBoxRemoveDelegate(logTextBox.Clear), null);
            }
            decodeLine(line);

            updateView();
        }

        private void clearLog()
        {
            logTextBox.Clear();

            for (int i = 0; i < 3; i++)
            {
                pos[i].Clear();
                speed[i].Clear();
                gpsPos[i].Clear();
            }

            updateView();
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            Console.WriteLine("error received");
        }

        private void commandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return){
                object[] args = { ">>"+commandTextBox.Text + "\n" };
                BeginInvoke(new textBoxDelegate(logTextBox.AppendText), args);

                
                lock (serialPort1)
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write(commandTextBox.Text + "\r");
                    }
                }


                if (commandTextBox.Text.Length != 0)
                {
                    commandLog.Add(commandTextBox.Text);
                    commandLogIndex = commandLog.Count;
                }

                commandTextBox.Text = "";
                e.Handled = true;
            }
        }

        private void commandTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (0 < commandLogIndex)
                {
                    commandLogIndex--;
                    commandTextBox.Text = commandLog[commandLogIndex];
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (commandLogIndex < commandLog.Count - 1)
                {
                    commandLogIndex++;
                    commandTextBox.Text = commandLog[commandLogIndex];
                }
                else if (commandLogIndex == commandLog.Count-1)
                {
                    commandLogIndex++;
                    commandTextBox.Text = "";
                }
            }
        }

        private void checkBoxJoypadEnable_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBoxJoypadEnable.Checked;
        }

        private void comboBoxJoypad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxJoypad.SelectedIndex != -1)
            {
                joypadController = new JoypadController(comboBoxJoypad.SelectedIndex);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clearLog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileStream = File.OpenRead(openFileDialog1.FileName);
                fileReader = new StreamReader(fileStream,Encoding.GetEncoding("Shift_JIS"));
                filenameLabel.Text = openFileDialog1.SafeFileName;
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, System.Text.Encoding.GetEncoding("Shift_JIS"));
                    for (int i = 0; i < logTextBox.Lines.Length; i++)
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(logTextBox.Lines[i], "^>>.*"))
                        {
                            sw.WriteLine(logTextBox.Lines[i]);
                        }
                        else
                        {
                            Console.WriteLine(logTextBox.Lines[i]);
                        }

                    }

                    sw.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("cannot open file");
                }
            }
            

        }

        private void buttonFileRewind_Click(object sender, EventArgs e)
        {
            if (fileReader != null)
            {
                fileStream.Seek(0, SeekOrigin.Begin);
            }
        }

        private void buttonFileStop_Click(object sender, EventArgs e)
        {
            timerFilePlay.Enabled = false;
        }

        private void buttonFileStart_Click(object sender, EventArgs e)
        {
            timerFilePlay.Enabled = true;
        }

        private void buttonFileQue_Click(object sender, EventArgs e)
        {
            string line;
            if (fileReader != null)
            {
                buttonFileQue.Enabled = false;
                buttonFileStart.Enabled = false;
                buttonFileStop.Enabled = false;
                buttonFileRewind.Enabled = false;

                while ((line = fileReader.ReadLine()) != null)
                {
                    handleReceivedLine(line);
                }
                buttonFileQue.Enabled = true;
                buttonFileStart.Enabled = true;
                buttonFileStop.Enabled = true;
                buttonFileRewind.Enabled = true;
            }
        }

        private void timerFilePlay_Tick(object sender, EventArgs e)
        {
            if (fileReader == null)
            {
                timerFilePlay.Enabled = false;
                return;
            }

            string line = fileReader.ReadLine();
            if (line == null)
            {
                timerFilePlay.Enabled = false;
                return;
            }

            handleReceivedLine(line);


        }

        private void comboBoxScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateView();
        }

        private double getGpsScale(ComboBox source)
        {
            string scaleString = (string)source.Items[source.SelectedIndex];

            int scale;

            if (System.Text.RegularExpressions.Regex.IsMatch(scaleString, ".+km$"))
            {
                scale = 1000;
            }else{
                scale = 1;
            }

            scaleString = System.Text.RegularExpressions.Regex.Replace(scaleString, "[^0-9]", "");

            scale *= int.Parse(scaleString);

            return scale;
        }

        private void paintSpeedPlot(Pen pen, PaintEventArgs e, double speedX, double speedY, double scaleX, double scaleY, int offsetX, int offsetY)
        {
            //X,Y are in screen coordinate
            Graphics g = e.Graphics;

            int width = e.ClipRectangle.Width;
            int height = e.ClipRectangle.Height;

            //grid line
            g.DrawLine(Pens.LightGray, 0, height - offsetY, width, height - offsetY);
            g.DrawLine(Pens.LightGray, offsetX, 0, offsetX, height);

            g.DrawLine(pen,offsetX,offsetY,(int)(offsetX + speedX*scaleX),(int)(offsetY - speedY*scaleY));
        }
        private void paintAttitudePlot(Pen pen, PaintEventArgs e, double degDirection, int offsetX, int offsetY)
        {
            Graphics g = e.Graphics;

            int width = e.ClipRectangle.Width;
            int height = e.ClipRectangle.Height;

            g.DrawLine(pen,offsetX,offsetY,(int)(offsetX-(width/4)*Math.Sin(degDirection*Math.PI/180)),(int)(offsetY-(height/4)*Math.Cos(degDirection*Math.PI/180)));
        }


        private void paintPositionPlot(Pen pen,PaintEventArgs e,List<double> sourceX,List<double> sourceY,List<double> speedX,List<double>speedY,double scaleX,double scaleY,int offsetX,int offsetY)
        {
            //X,Y are in screen coordinate.

            int width = e.ClipRectangle.Width;
            int height = e.ClipRectangle.Height;

            double localOffsetX=0;
            double localOffsetY=0;

            double currentSpeedX;
            double currentSpeedY;
            try{
                currentSpeedX = speedX[speedX.Count - 1];
                currentSpeedY = speedY[speedY.Count - 1];
            }catch(ArgumentOutOfRangeException){
                currentSpeedX = 0;
                currentSpeedY = 0;
            }

            Graphics g = e.Graphics;

            //grid line
            g.DrawLine(Pens.LightGray, 0, height - offsetY, width, height - offsetY);
            g.DrawLine(Pens.LightGray, offsetX, 0, offsetX, height);

            int decimation;
            try
            {
                decimation = int.Parse(System.Text.RegularExpressions.Regex.Replace(comboBoxDecimation.Text, "[^0-9]", ""));
            }
            catch (FormatException)
            {
                decimation = 1;
            }

            if (checkBoxDrawAtCenter.Checked)
            {
                if (0 < sourceX.Count)
                {
                    localOffsetX = sourceX[sourceX.Count - 1];
                    localOffsetY = sourceY[sourceY.Count - 1];
                }
            }



            //pos line
            for (int i = 1+decimation; i < sourceX.Count; i+=decimation)
            {
                g.DrawLine(pen, (int)(offsetX + (sourceX[i - decimation]-localOffsetX) * scaleX), (int)(height- offsetY - (sourceY[i - decimation]-localOffsetY) * scaleY), (int)(offsetX + (sourceX[i]-localOffsetX) * scaleX), (int)(height - offsetY - (sourceY[i]-localOffsetY) * scaleY));

            }

            //speed line
            if (buttonShowSpeed.Checked)
            {
                try
                {
                    g.DrawLine(Pens.Red, (int)(offsetX + sourceX[sourceX.Count - 1] * scaleX), (int)(height - offsetY - sourceY[sourceY.Count - 1] * scaleY),
                        (int)(offsetX + (sourceX[sourceX.Count - 1] + currentSpeedX) * scaleX), (int)(height - offsetY - (sourceY[sourceY.Count - 1] + currentSpeedY) * scaleY));
                }
                catch (ArgumentOutOfRangeException)
                {
                }
            }



        }

        private void pictureBoxPositionLogXY_Paint(object sender, PaintEventArgs e)
        {
            //X,Y are in earth frame.
            //X = north, Y = west

            int offsetX = e.ClipRectangle.Width /2 ;
            int offsetY = e.ClipRectangle.Height / 2;

            double scale = getGpsScale(comboBoxScaleXY);

            double multiplierX = e.ClipRectangle.Width / 2 / scale;
            double multiplierY = - e.ClipRectangle.Height / 2 / scale;

            paintPositionPlot(Pens.Black,e, pos[1], pos[0], speed[1], speed[0], multiplierY, multiplierX, offsetY, offsetX);

            paintPositionPlot(Pens.Green,e,gpsPos[1], gpsPos[0], speed[1], speed[0], multiplierY, multiplierX, offsetY, offsetX);

        }
        private void pictureBoxPositionLogYZ_Paint(object sender, PaintEventArgs e)
        {
            //X,Y are in earth frame.
            //X = north, Y = west

            int offsetY = e.ClipRectangle.Width / 2;
            int offsetZ = e.ClipRectangle.Height/ 4;

            double scaleX = getGpsScale(comboBoxScaleXY);
            double scaleY = getGpsScale(comboBoxScaleZ);

            double multiplierY = - e.ClipRectangle.Width / 2 / scaleX;
            double multiplierZ = e.ClipRectangle.Height *7/ 8 /scaleY;

            paintPositionPlot(Pens.Black,e, pos[1], pos[2], speed[1], speed[2], multiplierY, multiplierZ, offsetY, offsetZ);
            

        }

        private void pictureBoxXYSpeed_Paint(object sender, PaintEventArgs e)
        {
            int offsetY = e.ClipRectangle.Width / 2;
            int offsetX = e.ClipRectangle.Height / 2;

            if (speed[0].Count != 0)
            {
                paintSpeedPlot(Pens.Red, e, speed[1][speed[1].Count - 1], speed[0][speed[0].Count - 1], -10, 10, offsetY, offsetX);
                paintAttitudePlot(Pens.Green, e, heading , offsetX, offsetY);
            }
        }

        private void pictureBoxYZSpeed_Paint(object sender, PaintEventArgs e)
        {
            int offsetY = e.ClipRectangle.Width / 2;
            int offsetZ = e.ClipRectangle.Height / 2;

            if (speed[1].Count != 0)
            {
                paintSpeedPlot(Pens.Red, e, speed[1][speed[1].Count - 1], speed[2][speed[2].Count - 1], -10, 10, offsetY, offsetZ);

                double mpsSpeed = Math.Sqrt(speed[0][speed[0].Count - 1] * speed[0][speed[0].Count - 1] + speed[1][speed[1].Count - 1] * speed[1][speed[1].Count - 1] + speed[2][speed[2].Count - 1] * speed[2][speed[2].Count - 1]);

                labelSpeedMps.Text = mpsSpeed.ToString("F3") + "m/s";
                labelSpeedKmph.Text = (mpsSpeed * 3.6).ToString("F3") + "km/s";
            }


            
        }

        private void pictureBoxPitchSpeed_Paint(object sender, PaintEventArgs e)
        {
            int offsetY = e.ClipRectangle.Width / 2;
            int offsetZ = e.ClipRectangle.Height / 2;

            if (speed[1].Count != 0)
            {
                double horizontalSpeed = Math.Sqrt(speed[1][speed[1].Count - 1] * speed[1][speed[1].Count - 1] + speed[0][speed[0].Count - 1] * speed[0][speed[0].Count - 1]);
                paintSpeedPlot(Pens.Red, e,-horizontalSpeed, speed[2][speed[2].Count - 1], -10, 10, offsetY, offsetZ);
                paintAttitudePlot(Pens.Green, e, -pitch-90, offsetY, offsetZ);

                labelAoa.Text = "AOA: " + (pitch + Math.Atan2(speed[2][speed[2].Count - 1], horizontalSpeed) * 180 / Math.PI).ToString("F3") + "deg";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("reset inu\r");
                clearLog();
                Thread.Sleep(100);
                
                serialPort1.DiscardInBuffer();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("print attitude\r");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("print attitude earthframe\r");
            }
        }














    }
}
