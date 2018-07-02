namespace FrequencySynthesisModuleController
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSerialPort = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPulseWidth = new System.Windows.Forms.TextBox();
            this.btnPulse = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDuty = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnFreq = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFreq = new System.Windows.Forms.TextBox();
            this.rbSilence = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbAlarm9 = new System.Windows.Forms.PictureBox();
            this.pbAlarm8 = new System.Windows.Forms.PictureBox();
            this.pbAlarm7 = new System.Windows.Forms.PictureBox();
            this.pbAlarm6 = new System.Windows.Forms.PictureBox();
            this.pbAlarm5 = new System.Windows.Forms.PictureBox();
            this.pbAlarm4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbAlarm3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbAlarm2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAlarm1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbSerialPort);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbSerialPort);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "통신";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(311, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "통신상태";
            // 
            // pbSerialPort
            // 
            this.pbSerialPort.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbSerialPort.InitialImage = null;
            this.pbSerialPort.Location = new System.Drawing.Point(333, 28);
            this.pbSerialPort.Name = "pbSerialPort";
            this.pbSerialPort.Size = new System.Drawing.Size(16, 16);
            this.pbSerialPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSerialPort.TabIndex = 4;
            this.pbSerialPort.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(396, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(163, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "OPEN";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(15, 30);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(130, 31);
            this.cbSerialPort.TabIndex = 1;
            this.cbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cbSerialPort_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(21, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(527, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "차기대포병탐지레이더 주파수합성모듈1(FSM1)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox10);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.tbPulseWidth);
            this.groupBox7.Controls.Add(this.btnPulse);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.tbDuty);
            this.groupBox7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.Location = new System.Drawing.Point(264, 335);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(281, 368);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PULSE WIDTH/DUTY";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::FrequencySynthesisModuleController.Properties.Resources.pulsewithduty;
            this.pictureBox10.Location = new System.Drawing.Point(15, 28);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(260, 187);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 19);
            this.label17.TabIndex = 22;
            this.label17.Text = "Duty";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 19);
            this.label16.TabIndex = 21;
            this.label16.Text = "P.W";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(251, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "us";
            // 
            // tbPulseWidth
            // 
            this.tbPulseWidth.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPulseWidth.Location = new System.Drawing.Point(66, 234);
            this.tbPulseWidth.Name = "tbPulseWidth";
            this.tbPulseWidth.Size = new System.Drawing.Size(179, 36);
            this.tbPulseWidth.TabIndex = 19;
            this.tbPulseWidth.Text = "0.0";
            this.tbPulseWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPulseWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPulseWidth_KeyPress);
            // 
            // btnPulse
            // 
            this.btnPulse.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPulse.Location = new System.Drawing.Point(66, 320);
            this.btnPulse.Name = "btnPulse";
            this.btnPulse.Size = new System.Drawing.Size(179, 36);
            this.btnPulse.TabIndex = 12;
            this.btnPulse.Text = "SEND";
            this.btnPulse.UseVisualStyleBackColor = true;
            this.btnPulse.Click += new System.EventHandler(this.btnPulse_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(251, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 19);
            this.label14.TabIndex = 18;
            this.label14.Text = "us";
            // 
            // tbDuty
            // 
            this.tbDuty.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuty.Location = new System.Drawing.Point(66, 277);
            this.tbDuty.Name = "tbDuty";
            this.tbDuty.Size = new System.Drawing.Size(179, 36);
            this.tbDuty.TabIndex = 0;
            this.tbDuty.Text = "0.0";
            this.tbDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDuty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDuty_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnFreq);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.tbFreq);
            this.groupBox6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(264, 242);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 81);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "FREQ. SELECT";
            // 
            // btnFreq
            // 
            this.btnFreq.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreq.Location = new System.Drawing.Point(155, 28);
            this.btnFreq.Name = "btnFreq";
            this.btnFreq.Size = new System.Drawing.Size(120, 36);
            this.btnFreq.TabIndex = 12;
            this.btnFreq.Text = "SEND";
            this.btnFreq.UseVisualStyleBackColor = true;
            this.btnFreq.Click += new System.EventHandler(this.btnFreq_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(123, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 19);
            this.label13.TabIndex = 18;
            this.label13.Text = "No.";
            // 
            // tbFreq
            // 
            this.tbFreq.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFreq.Location = new System.Drawing.Point(15, 28);
            this.tbFreq.Name = "tbFreq";
            this.tbFreq.Size = new System.Drawing.Size(107, 36);
            this.tbFreq.TabIndex = 0;
            this.tbFreq.Text = "0";
            this.tbFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFreq_KeyPress);
            // 
            // rbSilence
            // 
            this.rbSilence.AutoSize = true;
            this.rbSilence.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSilence.Location = new System.Drawing.Point(155, 35);
            this.rbSilence.Name = "rbSilence";
            this.rbSilence.Size = new System.Drawing.Size(91, 27);
            this.rbSilence.TabIndex = 20;
            this.rbSilence.TabStop = true;
            this.rbSilence.Text = "SILENCE";
            this.rbSilence.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(26, 35);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(98, 27);
            this.rbNormal.TabIndex = 19;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "NORMAL";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbTemp);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(23, 521);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 75);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TEMP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(172, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "°C";
            // 
            // tbTemp
            // 
            this.tbTemp.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemp.Location = new System.Drawing.Point(42, 28);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.ReadOnly = true;
            this.tbTemp.Size = new System.Drawing.Size(124, 36);
            this.tbTemp.TabIndex = 0;
            this.tbTemp.Text = "0.0";
            this.tbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pbAlarm9);
            this.groupBox2.Controls.Add(this.pbAlarm8);
            this.groupBox2.Controls.Add(this.pbAlarm7);
            this.groupBox2.Controls.Add(this.pbAlarm6);
            this.groupBox2.Controls.Add(this.pbAlarm5);
            this.groupBox2.Controls.Add(this.pbAlarm4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pbAlarm3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbAlarm2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pbAlarm1);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(23, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 360);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALARM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(50, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "WARM UP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "+6.6V OVER CURRENT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "+5V OVER CURRENT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "+15V OVER CURRENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "CLK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "PLL OFFSET";
            // 
            // pbAlarm9
            // 
            this.pbAlarm9.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm9.Location = new System.Drawing.Point(15, 320);
            this.pbAlarm9.Name = "pbAlarm9";
            this.pbAlarm9.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm9.TabIndex = 11;
            this.pbAlarm9.TabStop = false;
            // 
            // pbAlarm8
            // 
            this.pbAlarm8.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm8.Location = new System.Drawing.Point(15, 285);
            this.pbAlarm8.Name = "pbAlarm8";
            this.pbAlarm8.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm8.TabIndex = 10;
            this.pbAlarm8.TabStop = false;
            // 
            // pbAlarm7
            // 
            this.pbAlarm7.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm7.Location = new System.Drawing.Point(15, 250);
            this.pbAlarm7.Name = "pbAlarm7";
            this.pbAlarm7.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm7.TabIndex = 9;
            this.pbAlarm7.TabStop = false;
            // 
            // pbAlarm6
            // 
            this.pbAlarm6.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm6.Location = new System.Drawing.Point(15, 215);
            this.pbAlarm6.Name = "pbAlarm6";
            this.pbAlarm6.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm6.TabIndex = 8;
            this.pbAlarm6.TabStop = false;
            // 
            // pbAlarm5
            // 
            this.pbAlarm5.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm5.Location = new System.Drawing.Point(15, 180);
            this.pbAlarm5.Name = "pbAlarm5";
            this.pbAlarm5.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm5.TabIndex = 7;
            this.pbAlarm5.TabStop = false;
            // 
            // pbAlarm4
            // 
            this.pbAlarm4.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm4.Location = new System.Drawing.Point(15, 145);
            this.pbAlarm4.Name = "pbAlarm4";
            this.pbAlarm4.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm4.TabIndex = 6;
            this.pbAlarm4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "DDS CLK";
            // 
            // pbAlarm3
            // 
            this.pbAlarm3.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm3.Location = new System.Drawing.Point(15, 110);
            this.pbAlarm3.Name = "pbAlarm3";
            this.pbAlarm3.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm3.TabIndex = 4;
            this.pbAlarm3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "LO 3";
            // 
            // pbAlarm2
            // 
            this.pbAlarm2.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm2.Location = new System.Drawing.Point(15, 75);
            this.pbAlarm2.Name = "pbAlarm2";
            this.pbAlarm2.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm2.TabIndex = 2;
            this.pbAlarm2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "LO 1";
            // 
            // pbAlarm1
            // 
            this.pbAlarm1.Image = global::FrequencySynthesisModuleController.Properties.Resources.black_small;
            this.pbAlarm1.Location = new System.Drawing.Point(15, 40);
            this.pbAlarm1.Name = "pbAlarm1";
            this.pbAlarm1.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm1.TabIndex = 0;
            this.pbAlarm1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbNormal);
            this.groupBox5.Controls.Add(this.rbSilence);
            this.groupBox5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(264, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 81);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MODE SELECT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 722);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "주파수 합성 모듈 (FS1)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.PictureBox pbSerialPort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbAlarm9;
        private System.Windows.Forms.PictureBox pbAlarm8;
        private System.Windows.Forms.PictureBox pbAlarm7;
        private System.Windows.Forms.PictureBox pbAlarm6;
        private System.Windows.Forms.PictureBox pbAlarm5;
        private System.Windows.Forms.PictureBox pbAlarm4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbAlarm3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAlarm2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAlarm1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFreq;
        private System.Windows.Forms.Button btnFreq;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPulseWidth;
        private System.Windows.Forms.Button btnPulse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDuty;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.RadioButton rbSilence;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

