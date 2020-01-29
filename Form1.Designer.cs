namespace COMHelperV1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCOMOnOff = new System.Windows.Forms.Button();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lPortName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bReceivePause = new System.Windows.Forms.Button();
            this.bReceiveClear = new System.Windows.Forms.Button();
            this.chbReceiveAsHEX = new System.Windows.Forms.CheckBox();
            this.chbAutoClear = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bTransmit = new System.Windows.Forms.Button();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.bTransmitClear = new System.Windows.Forms.Button();
            this.chbTransmitAsHEX = new System.Windows.Forms.CheckBox();
            this.chbCircularTransmit = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbReceiveTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbTransmitTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bResetCount = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lReceiveCount = new System.Windows.Forms.Label();
            this.lTransmitCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPortName
            // 
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(88, 24);
            this.cbPortName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(78, 22);
            this.cbPortName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bCOMOnOff);
            this.groupBox1.Controls.Add(this.cbStopBits);
            this.groupBox1.Controls.Add(this.cbDataBits);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lPortName);
            this.groupBox1.Controls.Add(this.cbPortName);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(182, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMSettings";
            // 
            // bCOMOnOff
            // 
            this.bCOMOnOff.Location = new System.Drawing.Point(41, 175);
            this.bCOMOnOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCOMOnOff.Name = "bCOMOnOff";
            this.bCOMOnOff.Size = new System.Drawing.Size(100, 23);
            this.bCOMOnOff.TabIndex = 2;
            this.bCOMOnOff.Text = "Open";
            this.bCOMOnOff.UseVisualStyleBackColor = true;
            this.bCOMOnOff.Click += new System.EventHandler(this.bCOMOnOff_Click);
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(88, 147);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(78, 22);
            this.cbStopBits.TabIndex = 10;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(88, 117);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(78, 22);
            this.cbDataBits.TabIndex = 9;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(88, 87);
            this.cbParity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(78, 22);
            this.cbParity.TabIndex = 8;
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(88, 56);
            this.cbBaudrate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(78, 22);
            this.cbBaudrate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baudrate";
            // 
            // lPortName
            // 
            this.lPortName.AutoSize = true;
            this.lPortName.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPortName.Location = new System.Drawing.Point(8, 27);
            this.lPortName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPortName.Name = "lPortName";
            this.lPortName.Size = new System.Drawing.Size(72, 14);
            this.lPortName.TabIndex = 2;
            this.lPortName.Text = "Port Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSave);
            this.groupBox2.Controls.Add(this.bReceivePause);
            this.groupBox2.Controls.Add(this.bReceiveClear);
            this.groupBox2.Controls.Add(this.chbReceiveAsHEX);
            this.groupBox2.Controls.Add(this.chbAutoClear);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(182, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ReceiveSettings";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(12, 97);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bReceivePause
            // 
            this.bReceivePause.Location = new System.Drawing.Point(92, 68);
            this.bReceivePause.Name = "bReceivePause";
            this.bReceivePause.Size = new System.Drawing.Size(74, 52);
            this.bReceivePause.TabIndex = 1;
            this.bReceivePause.Text = "Pause";
            this.bReceivePause.UseVisualStyleBackColor = true;
            // 
            // bReceiveClear
            // 
            this.bReceiveClear.Location = new System.Drawing.Point(11, 68);
            this.bReceiveClear.Name = "bReceiveClear";
            this.bReceiveClear.Size = new System.Drawing.Size(75, 23);
            this.bReceiveClear.TabIndex = 0;
            this.bReceiveClear.Text = "Clear";
            this.bReceiveClear.UseVisualStyleBackColor = true;
            this.bReceiveClear.Click += new System.EventHandler(this.bReceiveClear_Click);
            // 
            // chbReceiveAsHEX
            // 
            this.chbReceiveAsHEX.AutoSize = true;
            this.chbReceiveAsHEX.Location = new System.Drawing.Point(11, 44);
            this.chbReceiveAsHEX.Name = "chbReceiveAsHEX";
            this.chbReceiveAsHEX.Size = new System.Drawing.Size(118, 18);
            this.chbReceiveAsHEX.TabIndex = 1;
            this.chbReceiveAsHEX.Text = "Receive as HEX";
            this.chbReceiveAsHEX.UseVisualStyleBackColor = true;
            // 
            // chbAutoClear
            // 
            this.chbAutoClear.AutoSize = true;
            this.chbAutoClear.Location = new System.Drawing.Point(11, 20);
            this.chbAutoClear.Name = "chbAutoClear";
            this.chbAutoClear.Size = new System.Drawing.Size(92, 18);
            this.chbAutoClear.TabIndex = 0;
            this.chbAutoClear.Text = "Auto Clear";
            this.chbAutoClear.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bTransmit);
            this.groupBox3.Controls.Add(this.tbInterval);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.bTransmitClear);
            this.groupBox3.Controls.Add(this.chbTransmitAsHEX);
            this.groupBox3.Controls.Add(this.chbCircularTransmit);
            this.groupBox3.Location = new System.Drawing.Point(16, 397);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(182, 180);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TransmitSettings";
            // 
            // bTransmit
            // 
            this.bTransmit.Location = new System.Drawing.Point(92, 99);
            this.bTransmit.Name = "bTransmit";
            this.bTransmit.Size = new System.Drawing.Size(74, 52);
            this.bTransmit.TabIndex = 1;
            this.bTransmit.Text = "Transmit";
            this.bTransmit.UseVisualStyleBackColor = true;
            this.bTransmit.Click += new System.EventHandler(this.bTransmit_Click);
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(96, 66);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(71, 21);
            this.tbInterval.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Interval(ms):";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Load File";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // bTransmitClear
            // 
            this.bTransmitClear.Location = new System.Drawing.Point(11, 99);
            this.bTransmitClear.Name = "bTransmitClear";
            this.bTransmitClear.Size = new System.Drawing.Size(75, 23);
            this.bTransmitClear.TabIndex = 0;
            this.bTransmitClear.Text = "Clear";
            this.bTransmitClear.UseVisualStyleBackColor = true;
            this.bTransmitClear.Click += new System.EventHandler(this.bTransmitClear_Click);
            // 
            // chbTransmitAsHEX
            // 
            this.chbTransmitAsHEX.AutoSize = true;
            this.chbTransmitAsHEX.Location = new System.Drawing.Point(11, 44);
            this.chbTransmitAsHEX.Name = "chbTransmitAsHEX";
            this.chbTransmitAsHEX.Size = new System.Drawing.Size(130, 18);
            this.chbTransmitAsHEX.TabIndex = 0;
            this.chbTransmitAsHEX.Text = "Transmit as HEX";
            this.chbTransmitAsHEX.UseVisualStyleBackColor = true;
            // 
            // chbCircularTransmit
            // 
            this.chbCircularTransmit.AutoSize = true;
            this.chbCircularTransmit.Location = new System.Drawing.Point(11, 20);
            this.chbCircularTransmit.Name = "chbCircularTransmit";
            this.chbCircularTransmit.Size = new System.Drawing.Size(136, 18);
            this.chbCircularTransmit.TabIndex = 0;
            this.chbCircularTransmit.Text = "Circular Transmit";
            this.chbCircularTransmit.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbReceiveTextBox);
            this.groupBox4.Location = new System.Drawing.Point(206, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(554, 377);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ReceiveZone";
            // 
            // tbReceiveTextBox
            // 
            this.tbReceiveTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.tbReceiveTextBox.Location = new System.Drawing.Point(11, 20);
            this.tbReceiveTextBox.Multiline = true;
            this.tbReceiveTextBox.Name = "tbReceiveTextBox";
            this.tbReceiveTextBox.ReadOnly = true;
            this.tbReceiveTextBox.Size = new System.Drawing.Size(532, 351);
            this.tbReceiveTextBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbTransmitTextBox);
            this.groupBox5.Location = new System.Drawing.Point(206, 397);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(554, 122);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TransmitZone";
            // 
            // tbTransmitTextBox
            // 
            this.tbTransmitTextBox.Location = new System.Drawing.Point(11, 17);
            this.tbTransmitTextBox.Multiline = true;
            this.tbTransmitTextBox.Name = "tbTransmitTextBox";
            this.tbTransmitTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTransmitTextBox.Size = new System.Drawing.Size(532, 91);
            this.tbTransmitTextBox.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bResetCount);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.lReceiveCount);
            this.groupBox6.Controls.Add(this.lTransmitCount);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(205, 525);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(555, 52);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MessageZone";
            // 
            // bResetCount
            // 
            this.bResetCount.Location = new System.Drawing.Point(493, 19);
            this.bResetCount.Name = "bResetCount";
            this.bResetCount.Size = new System.Drawing.Size(55, 23);
            this.bResetCount.TabIndex = 5;
            this.bResetCount.Text = "Reset";
            this.bResetCount.UseVisualStyleBackColor = true;
            this.bResetCount.Click += new System.EventHandler(this.bResetCount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "Transmit Count(bytes):";
            // 
            // lReceiveCount
            // 
            this.lReceiveCount.AutoSize = true;
            this.lReceiveCount.Location = new System.Drawing.Point(399, 23);
            this.lReceiveCount.Name = "lReceiveCount";
            this.lReceiveCount.Size = new System.Drawing.Size(14, 14);
            this.lReceiveCount.TabIndex = 4;
            this.lReceiveCount.Text = "0";
            // 
            // lTransmitCount
            // 
            this.lTransmitCount.AutoSize = true;
            this.lTransmitCount.Location = new System.Drawing.Point(169, 23);
            this.lTransmitCount.Name = "lTransmitCount";
            this.lTransmitCount.Size = new System.Drawing.Size(14, 14);
            this.lTransmitCount.TabIndex = 2;
            this.lTransmitCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 14);
            this.label10.TabIndex = 3;
            this.label10.Text = "Receive Count(bytes):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 584);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "COMHelperV1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bCOMOnOff;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lPortName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chbReceiveAsHEX;
        private System.Windows.Forms.CheckBox chbAutoClear;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bReceiveClear;
        private System.Windows.Forms.Button bTransmitClear;
        private System.Windows.Forms.CheckBox chbTransmitAsHEX;
        private System.Windows.Forms.CheckBox chbCircularTransmit;
        private System.Windows.Forms.TextBox tbTransmitTextBox;
        private System.Windows.Forms.TextBox tbReceiveTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bTransmit;
        private System.Windows.Forms.Button bResetCount;
        private System.Windows.Forms.Label lReceiveCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lTransmitCount;
        private System.Windows.Forms.Label label8;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button bReceivePause;
    }
}

