namespace DateTimeStructureDemo
{
    partial class FormOperation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddSeconds = new System.Windows.Forms.Button();
            this.buttonAddMinutes = new System.Windows.Forms.Button();
            this.buttonAddHours = new System.Windows.Forms.Button();
            this.buttonAddYears = new System.Windows.Forms.Button();
            this.buttonAddMonths = new System.Windows.Forms.Button();
            this.buttonAddDays = new System.Windows.Forms.Button();
            this.textBoxCurrentDateTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetCurrentDateAndTime = new System.Windows.Forms.Button();
            this.textBoxAddDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddMonths = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddYears = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddHours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddMinutes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAddSeconds = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddSeconds);
            this.groupBox1.Controls.Add(this.buttonAddMinutes);
            this.groupBox1.Controls.Add(this.buttonAddHours);
            this.groupBox1.Controls.Add(this.buttonAddYears);
            this.groupBox1.Controls.Add(this.buttonAddMonths);
            this.groupBox1.Controls.Add(this.buttonAddDays);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(434, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Methods";
            // 
            // buttonAddSeconds
            // 
            this.buttonAddSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSeconds.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddSeconds.Location = new System.Drawing.Point(211, 159);
            this.buttonAddSeconds.Name = "buttonAddSeconds";
            this.buttonAddSeconds.Size = new System.Drawing.Size(175, 49);
            this.buttonAddSeconds.TabIndex = 5;
            this.buttonAddSeconds.Text = "AddSeconds(seconds)";
            this.buttonAddSeconds.UseVisualStyleBackColor = true;
            this.buttonAddSeconds.Click += new System.EventHandler(this.buttonAddSeconds_Click);
            // 
            // buttonAddMinutes
            // 
            this.buttonAddMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMinutes.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddMinutes.Location = new System.Drawing.Point(211, 95);
            this.buttonAddMinutes.Name = "buttonAddMinutes";
            this.buttonAddMinutes.Size = new System.Drawing.Size(166, 49);
            this.buttonAddMinutes.TabIndex = 4;
            this.buttonAddMinutes.Text = "AddMinutes(minutes)";
            this.buttonAddMinutes.UseVisualStyleBackColor = true;
            this.buttonAddMinutes.Click += new System.EventHandler(this.buttonAddMinutes_Click);
            // 
            // buttonAddHours
            // 
            this.buttonAddHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddHours.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddHours.Location = new System.Drawing.Point(211, 40);
            this.buttonAddHours.Name = "buttonAddHours";
            this.buttonAddHours.Size = new System.Drawing.Size(166, 49);
            this.buttonAddHours.TabIndex = 3;
            this.buttonAddHours.Text = "AddHours(hours)";
            this.buttonAddHours.UseVisualStyleBackColor = true;
            this.buttonAddHours.Click += new System.EventHandler(this.buttonAddHours_Click);
            // 
            // buttonAddYears
            // 
            this.buttonAddYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddYears.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddYears.Location = new System.Drawing.Point(24, 159);
            this.buttonAddYears.Name = "buttonAddYears";
            this.buttonAddYears.Size = new System.Drawing.Size(158, 49);
            this.buttonAddYears.TabIndex = 2;
            this.buttonAddYears.Text = "AddYears(years)";
            this.buttonAddYears.UseVisualStyleBackColor = true;
            this.buttonAddYears.Click += new System.EventHandler(this.buttonAddYears_Click);
            // 
            // buttonAddMonths
            // 
            this.buttonAddMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMonths.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddMonths.Location = new System.Drawing.Point(24, 95);
            this.buttonAddMonths.Name = "buttonAddMonths";
            this.buttonAddMonths.Size = new System.Drawing.Size(158, 49);
            this.buttonAddMonths.TabIndex = 1;
            this.buttonAddMonths.Text = "AddMonths(months)";
            this.buttonAddMonths.UseVisualStyleBackColor = true;
            this.buttonAddMonths.Click += new System.EventHandler(this.buttonAddMonths_Click);
            // 
            // buttonAddDays
            // 
            this.buttonAddDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDays.ForeColor = System.Drawing.Color.Blue;
            this.buttonAddDays.Location = new System.Drawing.Point(24, 40);
            this.buttonAddDays.Name = "buttonAddDays";
            this.buttonAddDays.Size = new System.Drawing.Size(158, 49);
            this.buttonAddDays.TabIndex = 0;
            this.buttonAddDays.Text = "AddDays(days)";
            this.buttonAddDays.UseVisualStyleBackColor = true;
            this.buttonAddDays.Click += new System.EventHandler(this.buttonAddDays_Click);
            // 
            // textBoxCurrentDateTime
            // 
            this.textBoxCurrentDateTime.Location = new System.Drawing.Point(35, 72);
            this.textBoxCurrentDateTime.Name = "textBoxCurrentDateTime";
            this.textBoxCurrentDateTime.Size = new System.Drawing.Size(198, 20);
            this.textBoxCurrentDateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current date and time";
            // 
            // buttonGetCurrentDateAndTime
            // 
            this.buttonGetCurrentDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCurrentDateAndTime.ForeColor = System.Drawing.Color.Blue;
            this.buttonGetCurrentDateAndTime.Location = new System.Drawing.Point(279, 68);
            this.buttonGetCurrentDateAndTime.Name = "buttonGetCurrentDateAndTime";
            this.buttonGetCurrentDateAndTime.Size = new System.Drawing.Size(120, 34);
            this.buttonGetCurrentDateAndTime.TabIndex = 3;
            this.buttonGetCurrentDateAndTime.Text = "Get";
            this.buttonGetCurrentDateAndTime.UseVisualStyleBackColor = true;
            this.buttonGetCurrentDateAndTime.Click += new System.EventHandler(this.buttonGetCurrentDateAndTime_Click);
            // 
            // textBoxAddDays
            // 
            this.textBoxAddDays.Location = new System.Drawing.Point(35, 131);
            this.textBoxAddDays.Name = "textBoxAddDays";
            this.textBoxAddDays.Size = new System.Drawing.Size(152, 20);
            this.textBoxAddDays.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "AddDays(2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "AddMonths(1)";
            // 
            // textBoxAddMonths
            // 
            this.textBoxAddMonths.Location = new System.Drawing.Point(35, 186);
            this.textBoxAddMonths.Name = "textBoxAddMonths";
            this.textBoxAddMonths.Size = new System.Drawing.Size(152, 20);
            this.textBoxAddMonths.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "AddYears(3)";
            // 
            // textBoxAddYears
            // 
            this.textBoxAddYears.Location = new System.Drawing.Point(32, 240);
            this.textBoxAddYears.Name = "textBoxAddYears";
            this.textBoxAddYears.Size = new System.Drawing.Size(152, 20);
            this.textBoxAddYears.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "AddHours(2)";
            // 
            // textBoxAddHours
            // 
            this.textBoxAddHours.Location = new System.Drawing.Point(249, 131);
            this.textBoxAddHours.Name = "textBoxAddHours";
            this.textBoxAddHours.Size = new System.Drawing.Size(152, 20);
            this.textBoxAddHours.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "AddMinutes(60)";
            // 
            // textBoxAddMinutes
            // 
            this.textBoxAddMinutes.Location = new System.Drawing.Point(249, 186);
            this.textBoxAddMinutes.Name = "textBoxAddMinutes";
            this.textBoxAddMinutes.Size = new System.Drawing.Size(152, 20);
            this.textBoxAddMinutes.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "AddSeconds(120)";
            // 
            // textBoxAddSeconds
            // 
            this.textBoxAddSeconds.Location = new System.Drawing.Point(249, 240);
            this.textBoxAddSeconds.Name = "textBoxAddSeconds";
            this.textBoxAddSeconds.Size = new System.Drawing.Size(152, 20);
            this.textBoxAddSeconds.TabIndex = 14;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Blue;
            this.buttonBack.Location = new System.Drawing.Point(32, 294);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 32);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "&Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 360);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAddSeconds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAddMinutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAddHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddYears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddMonths);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAddDays);
            this.Controls.Add(this.buttonGetCurrentDateAndTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCurrentDateTime);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOperation";
            this.Text = "Methods for performing operations on dates and times";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddSeconds;
        private System.Windows.Forms.Button buttonAddMinutes;
        private System.Windows.Forms.Button buttonAddHours;
        private System.Windows.Forms.Button buttonAddYears;
        private System.Windows.Forms.Button buttonAddMonths;
        private System.Windows.Forms.Button buttonAddDays;
        private System.Windows.Forms.TextBox textBoxCurrentDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetCurrentDateAndTime;
        private System.Windows.Forms.TextBox textBoxAddDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddMonths;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddYears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddMinutes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAddSeconds;
        private System.Windows.Forms.Button buttonBack;
    }
}