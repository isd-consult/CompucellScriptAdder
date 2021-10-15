namespace CompucellScriptAdder
{
    partial class Form
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.tbxProjectPath = new System.Windows.Forms.TextBox();
            this.btnEncrpyt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemperaturePanel = new System.Windows.Forms.Button();
            this.tbxInterval = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxInitialZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxInitialX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDimension = new System.Windows.Forms.Button();
            this.tbxInitialY = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSteps = new System.Windows.Forms.TextBox();
            this.btnStepsPanel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxFlip2DimRatio = new System.Windows.Forms.TextBox();
            this.btnFlip2DimRatioPanel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxNeighborOrder = new System.Windows.Forms.TextBox();
            this.btnNeighborOrderPanel = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxTargetVolume = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVolumePanel = new System.Windows.Forms.Button();
            this.tbxLambdaVolume = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(704, 68);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Location = new System.Drawing.Point(28, 73);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(62, 13);
            this.lblProjectPath.TabIndex = 1;
            this.lblProjectPath.Text = "ProjectPath";
            // 
            // tbxProjectPath
            // 
            this.tbxProjectPath.Location = new System.Drawing.Point(96, 70);
            this.tbxProjectPath.Name = "tbxProjectPath";
            this.tbxProjectPath.Size = new System.Drawing.Size(601, 20);
            this.tbxProjectPath.TabIndex = 2;
            // 
            // btnEncrpyt
            // 
            this.btnEncrpyt.Location = new System.Drawing.Point(31, 14);
            this.btnEncrpyt.Name = "btnEncrpyt";
            this.btnEncrpyt.Size = new System.Drawing.Size(76, 23);
            this.btnEncrpyt.TabIndex = 4;
            this.btnEncrpyt.Text = "Encrypt";
            this.btnEncrpyt.UseVisualStyleBackColor = true;
            this.btnEncrpyt.Visible = false;
            this.btnEncrpyt.Click += new System.EventHandler(this.btnEncrpyt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxTemperature);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTemperaturePanel);
            this.groupBox1.Controls.Add(this.tbxInterval);
            this.groupBox1.Location = new System.Drawing.Point(31, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TemperaturePanel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Initial Temperature";
            // 
            // tbxTemperature
            // 
            this.tbxTemperature.Location = new System.Drawing.Point(21, 49);
            this.tbxTemperature.Name = "tbxTemperature";
            this.tbxTemperature.Size = new System.Drawing.Size(117, 20);
            this.tbxTemperature.TabIndex = 9;
            this.tbxTemperature.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Intitial Interval";
            // 
            // btnTemperaturePanel
            // 
            this.btnTemperaturePanel.Location = new System.Drawing.Point(21, 158);
            this.btnTemperaturePanel.Name = "btnTemperaturePanel";
            this.btnTemperaturePanel.Size = new System.Drawing.Size(117, 23);
            this.btnTemperaturePanel.TabIndex = 8;
            this.btnTemperaturePanel.Text = "Temperature Panel";
            this.btnTemperaturePanel.UseVisualStyleBackColor = true;
            this.btnTemperaturePanel.Click += new System.EventHandler(this.btnTemperaturePanel_Click);
            // 
            // tbxInterval
            // 
            this.tbxInterval.Location = new System.Drawing.Point(21, 115);
            this.tbxInterval.Name = "tbxInterval";
            this.tbxInterval.Size = new System.Drawing.Size(117, 20);
            this.tbxInterval.TabIndex = 10;
            this.tbxInterval.Text = "0.001";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbxInitialZ);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxInitialX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDimension);
            this.groupBox2.Controls.Add(this.tbxInitialY);
            this.groupBox2.Location = new System.Drawing.Point(616, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 208);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dimensions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Initial Z";
            // 
            // tbxInitialZ
            // 
            this.tbxInitialZ.Location = new System.Drawing.Point(21, 129);
            this.tbxInitialZ.Name = "tbxInitialZ";
            this.tbxInitialZ.Size = new System.Drawing.Size(117, 20);
            this.tbxInitialZ.TabIndex = 13;
            this.tbxInitialZ.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Initial X";
            // 
            // tbxInitialX
            // 
            this.tbxInitialX.Location = new System.Drawing.Point(21, 41);
            this.tbxInitialX.Name = "tbxInitialX";
            this.tbxInitialX.Size = new System.Drawing.Size(117, 20);
            this.tbxInitialX.TabIndex = 9;
            this.tbxInitialX.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Initial Y";
            // 
            // btnDimension
            // 
            this.btnDimension.Location = new System.Drawing.Point(21, 164);
            this.btnDimension.Name = "btnDimension";
            this.btnDimension.Size = new System.Drawing.Size(117, 23);
            this.btnDimension.TabIndex = 8;
            this.btnDimension.Text = "Dimension";
            this.btnDimension.UseVisualStyleBackColor = true;
            this.btnDimension.Click += new System.EventHandler(this.btnDimension_Click);
            // 
            // tbxInitialY
            // 
            this.tbxInitialY.Location = new System.Drawing.Point(21, 86);
            this.tbxInitialY.Name = "tbxInitialY";
            this.tbxInitialY.Size = new System.Drawing.Size(117, 20);
            this.tbxInitialY.TabIndex = 10;
            this.tbxInitialY.Text = "100";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbxSteps);
            this.groupBox3.Controls.Add(this.btnStepsPanel);
            this.groupBox3.Location = new System.Drawing.Point(336, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 208);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Steps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Initial Steps";
            // 
            // tbxSteps
            // 
            this.tbxSteps.Location = new System.Drawing.Point(21, 80);
            this.tbxSteps.Name = "tbxSteps";
            this.tbxSteps.Size = new System.Drawing.Size(117, 20);
            this.tbxSteps.TabIndex = 9;
            this.tbxSteps.Text = "10000";
            // 
            // btnStepsPanel
            // 
            this.btnStepsPanel.Location = new System.Drawing.Point(21, 158);
            this.btnStepsPanel.Name = "btnStepsPanel";
            this.btnStepsPanel.Size = new System.Drawing.Size(117, 23);
            this.btnStepsPanel.TabIndex = 8;
            this.btnStepsPanel.Text = "Steps Panel";
            this.btnStepsPanel.UseVisualStyleBackColor = true;
            this.btnStepsPanel.Click += new System.EventHandler(this.btnStepsPanel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbxFlip2DimRatio);
            this.groupBox4.Controls.Add(this.btnFlip2DimRatioPanel);
            this.groupBox4.Location = new System.Drawing.Point(616, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 208);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flip2DimRatio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Initial Flip2DimRatio";
            // 
            // tbxFlip2DimRatio
            // 
            this.tbxFlip2DimRatio.Location = new System.Drawing.Point(18, 80);
            this.tbxFlip2DimRatio.Name = "tbxFlip2DimRatio";
            this.tbxFlip2DimRatio.Size = new System.Drawing.Size(117, 20);
            this.tbxFlip2DimRatio.TabIndex = 9;
            this.tbxFlip2DimRatio.Text = "1";
            // 
            // btnFlip2DimRatioPanel
            // 
            this.btnFlip2DimRatioPanel.Location = new System.Drawing.Point(18, 158);
            this.btnFlip2DimRatioPanel.Name = "btnFlip2DimRatioPanel";
            this.btnFlip2DimRatioPanel.Size = new System.Drawing.Size(117, 23);
            this.btnFlip2DimRatioPanel.TabIndex = 8;
            this.btnFlip2DimRatioPanel.Text = "Flip2DimRatio Panel";
            this.btnFlip2DimRatioPanel.UseVisualStyleBackColor = true;
            this.btnFlip2DimRatioPanel.Click += new System.EventHandler(this.btnFlip2DimRatioPanel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tbxNeighborOrder);
            this.groupBox5.Controls.Add(this.btnNeighborOrderPanel);
            this.groupBox5.Location = new System.Drawing.Point(31, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 208);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "NeighborOrder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Initial NeighborOrder";
            // 
            // tbxNeighborOrder
            // 
            this.tbxNeighborOrder.Location = new System.Drawing.Point(21, 86);
            this.tbxNeighborOrder.Name = "tbxNeighborOrder";
            this.tbxNeighborOrder.Size = new System.Drawing.Size(117, 20);
            this.tbxNeighborOrder.TabIndex = 9;
            this.tbxNeighborOrder.Text = "2";
            // 
            // btnNeighborOrderPanel
            // 
            this.btnNeighborOrderPanel.Location = new System.Drawing.Point(21, 158);
            this.btnNeighborOrderPanel.Name = "btnNeighborOrderPanel";
            this.btnNeighborOrderPanel.Size = new System.Drawing.Size(117, 23);
            this.btnNeighborOrderPanel.TabIndex = 8;
            this.btnNeighborOrderPanel.Text = "NeighborOrder Panel";
            this.btnNeighborOrderPanel.UseVisualStyleBackColor = true;
            this.btnNeighborOrderPanel.Click += new System.EventHandler(this.btnNeighborOrderPanel_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.tbxTargetVolume);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.btnVolumePanel);
            this.groupBox7.Controls.Add(this.tbxLambdaVolume);
            this.groupBox7.Location = new System.Drawing.Point(336, 349);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 208);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Volume";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Initial Target Volume";
            // 
            // tbxTargetVolume
            // 
            this.tbxTargetVolume.Location = new System.Drawing.Point(21, 50);
            this.tbxTargetVolume.Name = "tbxTargetVolume";
            this.tbxTargetVolume.Size = new System.Drawing.Size(117, 20);
            this.tbxTargetVolume.TabIndex = 9;
            this.tbxTargetVolume.Text = "25";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Initial Lambda Volume";
            // 
            // btnVolumePanel
            // 
            this.btnVolumePanel.Location = new System.Drawing.Point(21, 164);
            this.btnVolumePanel.Name = "btnVolumePanel";
            this.btnVolumePanel.Size = new System.Drawing.Size(117, 23);
            this.btnVolumePanel.TabIndex = 8;
            this.btnVolumePanel.Text = "Volume Panel";
            this.btnVolumePanel.UseVisualStyleBackColor = true;
            this.btnVolumePanel.Click += new System.EventHandler(this.btnVolumePanel_Click);
            // 
            // tbxLambdaVolume
            // 
            this.tbxLambdaVolume.Location = new System.Drawing.Point(21, 115);
            this.tbxLambdaVolume.Name = "tbxLambdaVolume";
            this.tbxLambdaVolume.Size = new System.Drawing.Size(117, 20);
            this.tbxLambdaVolume.TabIndex = 10;
            this.tbxLambdaVolume.Text = "2";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 569);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncrpyt);
            this.Controls.Add(this.tbxProjectPath);
            this.Controls.Add(this.lblProjectPath);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form";
            this.Text = "CompucellScriptAdder";
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.TextBox tbxProjectPath;
        private System.Windows.Forms.Button btnEncrpyt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemperaturePanel;
        private System.Windows.Forms.TextBox tbxInterval;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxInitialZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxInitialX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDimension;
        private System.Windows.Forms.TextBox tbxInitialY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSteps;
        private System.Windows.Forms.Button btnStepsPanel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxFlip2DimRatio;
        private System.Windows.Forms.Button btnFlip2DimRatioPanel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxNeighborOrder;
        private System.Windows.Forms.Button btnNeighborOrderPanel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxTargetVolume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnVolumePanel;
        private System.Windows.Forms.TextBox tbxLambdaVolume;
    }
}

