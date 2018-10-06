namespace graphicsLaba2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rotation_X = new System.Windows.Forms.TrackBar();
            this.rotation_Y = new System.Windows.Forms.TrackBar();
            this.rotation_Z = new System.Windows.Forms.TrackBar();
            this.shift_X = new System.Windows.Forms.TrackBar();
            this.shift_Y = new System.Windows.Forms.TrackBar();
            this.shift_Z = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarZ0 = new System.Windows.Forms.TrackBar();
            this.reflectX = new System.Windows.Forms.CheckBox();
            this.reflectY = new System.Windows.Forms.CheckBox();
            this.reflectZ = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.scale_Z = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.scale_Y = new System.Windows.Forms.TrackBar();
            this.scale_X = new System.Windows.Forms.TrackBar();
            this.run = new System.Windows.Forms.CheckBox();
            this.timer_run = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotation_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotation_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotation_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shift_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shift_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shift_Z)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ0)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scale_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_X)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(865, 664);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rotation_X
            // 
            this.rotation_X.LargeChange = 1;
            this.rotation_X.Location = new System.Drawing.Point(3, 3);
            this.rotation_X.Maximum = 360;
            this.rotation_X.Minimum = -360;
            this.rotation_X.Name = "rotation_X";
            this.rotation_X.Size = new System.Drawing.Size(94, 34);
            this.rotation_X.TabIndex = 1;
            this.rotation_X.ValueChanged += new System.EventHandler(this.rotation_X_ValueChanged);
            // 
            // rotation_Y
            // 
            this.rotation_Y.LargeChange = 1;
            this.rotation_Y.Location = new System.Drawing.Point(3, 43);
            this.rotation_Y.Maximum = 360;
            this.rotation_Y.Minimum = -360;
            this.rotation_Y.Name = "rotation_Y";
            this.rotation_Y.Size = new System.Drawing.Size(94, 35);
            this.rotation_Y.TabIndex = 2;
            this.rotation_Y.ValueChanged += new System.EventHandler(this.rotation_Y_ValueChanged);
            // 
            // rotation_Z
            // 
            this.rotation_Z.LargeChange = 1;
            this.rotation_Z.Location = new System.Drawing.Point(3, 84);
            this.rotation_Z.Maximum = 360;
            this.rotation_Z.Minimum = -360;
            this.rotation_Z.Name = "rotation_Z";
            this.rotation_Z.Size = new System.Drawing.Size(94, 33);
            this.rotation_Z.TabIndex = 3;
            this.rotation_Z.ValueChanged += new System.EventHandler(this.rotation_Z_ValueChanged);
            // 
            // shift_X
            // 
            this.shift_X.LargeChange = 1;
            this.shift_X.Location = new System.Drawing.Point(3, 3);
            this.shift_X.Maximum = 500;
            this.shift_X.Minimum = -500;
            this.shift_X.Name = "shift_X";
            this.shift_X.Size = new System.Drawing.Size(94, 34);
            this.shift_X.TabIndex = 4;
            this.shift_X.ValueChanged += new System.EventHandler(this.shift_X_ValueChanged);
            // 
            // shift_Y
            // 
            this.shift_Y.LargeChange = 1;
            this.shift_Y.Location = new System.Drawing.Point(3, 43);
            this.shift_Y.Maximum = 500;
            this.shift_Y.Minimum = -500;
            this.shift_Y.Name = "shift_Y";
            this.shift_Y.Size = new System.Drawing.Size(94, 35);
            this.shift_Y.TabIndex = 5;
            this.shift_Y.ValueChanged += new System.EventHandler(this.shift_Y_ValueChanged);
            // 
            // shift_Z
            // 
            this.shift_Z.LargeChange = 1;
            this.shift_Z.Location = new System.Drawing.Point(3, 84);
            this.shift_Z.Maximum = 500;
            this.shift_Z.Minimum = -500;
            this.shift_Z.Name = "shift_Z";
            this.shift_Z.Size = new System.Drawing.Size(94, 33);
            this.shift_Z.TabIndex = 6;
            this.shift_Z.ValueChanged += new System.EventHandler(this.shift_Z_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поворот X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cдвиг X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 40);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cдвиг Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 81);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cдвиг Z";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rotation_Y, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rotation_X, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rotation_Z, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(874, 12);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 200);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 120);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 81);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Поворот Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 40);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Поворот Y";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.shift_Z, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.shift_Y, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.shift_X, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(874, 147);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(200, 200);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 120);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // trackBarZ0
            // 
            this.trackBarZ0.LargeChange = 25;
            this.trackBarZ0.Location = new System.Drawing.Point(874, 404);
            this.trackBarZ0.Maximum = 2000;
            this.trackBarZ0.Minimum = 1000;
            this.trackBarZ0.Name = "trackBarZ0";
            this.trackBarZ0.Size = new System.Drawing.Size(197, 45);
            this.trackBarZ0.TabIndex = 15;
            this.trackBarZ0.Value = 1000;
            this.trackBarZ0.ValueChanged += new System.EventHandler(this.trackBarZ0_ValueChanged);
            // 
            // reflectX
            // 
            this.reflectX.AutoSize = true;
            this.reflectX.Location = new System.Drawing.Point(871, 442);
            this.reflectX.Name = "reflectX";
            this.reflectX.Size = new System.Drawing.Size(93, 17);
            this.reflectX.TabIndex = 16;
            this.reflectX.Text = "Отражение Х";
            this.reflectX.UseVisualStyleBackColor = true;
            this.reflectX.CheckedChanged += new System.EventHandler(this.reflectX_CheckedChanged);
            // 
            // reflectY
            // 
            this.reflectY.AutoSize = true;
            this.reflectY.Location = new System.Drawing.Point(871, 465);
            this.reflectY.Name = "reflectY";
            this.reflectY.Size = new System.Drawing.Size(93, 17);
            this.reflectY.TabIndex = 17;
            this.reflectY.Text = "Отражение Y";
            this.reflectY.UseVisualStyleBackColor = true;
            this.reflectY.CheckedChanged += new System.EventHandler(this.reflectY_CheckedChanged);
            // 
            // reflectZ
            // 
            this.reflectZ.AutoSize = true;
            this.reflectZ.Location = new System.Drawing.Point(871, 488);
            this.reflectZ.Name = "reflectZ";
            this.reflectZ.Size = new System.Drawing.Size(93, 17);
            this.reflectZ.TabIndex = 18;
            this.reflectZ.Text = "Отражение Z";
            this.reflectZ.UseVisualStyleBackColor = true;
            this.reflectZ.CheckedChanged += new System.EventHandler(this.reflectZ_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.scale_Z, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.scale_Y, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.scale_X, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(874, 278);
            this.tableLayoutPanel3.MaximumSize = new System.Drawing.Size(200, 200);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.36709F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.63291F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 120);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // scale_Z
            // 
            this.scale_Z.LargeChange = 1;
            this.scale_Z.Location = new System.Drawing.Point(3, 84);
            this.scale_Z.Maximum = 500;
            this.scale_Z.Minimum = -500;
            this.scale_Z.Name = "scale_Z";
            this.scale_Z.Size = new System.Drawing.Size(94, 33);
            this.scale_Z.TabIndex = 6;
            this.scale_Z.ValueChanged += new System.EventHandler(this.scale_Z_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Масштаб X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 40);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Масштаб Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 81);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Масштаб Z";
            // 
            // scale_Y
            // 
            this.scale_Y.LargeChange = 1;
            this.scale_Y.Location = new System.Drawing.Point(3, 43);
            this.scale_Y.Maximum = 500;
            this.scale_Y.Minimum = -500;
            this.scale_Y.Name = "scale_Y";
            this.scale_Y.Size = new System.Drawing.Size(94, 35);
            this.scale_Y.TabIndex = 5;
            this.scale_Y.ValueChanged += new System.EventHandler(this.scale_Y_ValueChanged);
            // 
            // scale_X
            // 
            this.scale_X.LargeChange = 1;
            this.scale_X.Location = new System.Drawing.Point(3, 3);
            this.scale_X.Maximum = 500;
            this.scale_X.Minimum = -500;
            this.scale_X.Name = "scale_X";
            this.scale_X.Size = new System.Drawing.Size(94, 34);
            this.scale_X.TabIndex = 4;
            this.scale_X.ValueChanged += new System.EventHandler(this.scale_X_ValueChanged);
            // 
            // run
            // 
            this.run.AutoSize = true;
            this.run.Location = new System.Drawing.Point(871, 521);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(133, 17);
            this.run.TabIndex = 20;
            this.run.Text = "Движение по кривой";
            this.run.UseVisualStyleBackColor = true;
            this.run.CheckedChanged += new System.EventHandler(this.run_CheckedChanged);
            // 
            // timer_run
            // 
            this.timer_run.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 664);
            this.Controls.Add(this.run);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.reflectZ);
            this.Controls.Add(this.reflectY);
            this.Controls.Add(this.reflectX);
            this.Controls.Add(this.trackBarZ0);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Поворот X";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotation_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotation_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotation_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shift_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shift_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shift_Z)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ0)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scale_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale_X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar rotation_X;
        private System.Windows.Forms.TrackBar rotation_Y;
        private System.Windows.Forms.TrackBar rotation_Z;
        private System.Windows.Forms.TrackBar shift_X;
        private System.Windows.Forms.TrackBar shift_Y;
        private System.Windows.Forms.TrackBar shift_Z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TrackBar trackBarZ0;
        private System.Windows.Forms.CheckBox reflectX;
        private System.Windows.Forms.CheckBox reflectY;
        private System.Windows.Forms.CheckBox reflectZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TrackBar scale_Z;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar scale_Y;
        private System.Windows.Forms.TrackBar scale_X;
        private System.Windows.Forms.CheckBox run;
        private System.Windows.Forms.Timer timer_run;
    }
}

