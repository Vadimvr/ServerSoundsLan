namespace serverSound
{
    partial class ServerSounds
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
            this.ipAddres = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.portNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ipAddres
            // 
            this.ipAddres.Location = new System.Drawing.Point(132, 11);
            this.ipAddres.Name = "ipAddres";
            this.ipAddres.Size = new System.Drawing.Size(100, 20);
            this.ipAddres.TabIndex = 1;
            this.ipAddres.Text = "192.168.100.10";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(22, 76);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(132, 76);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // portNUD
            // 
            this.portNUD.Location = new System.Drawing.Point(168, 37);
            this.portNUD.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.portNUD.Name = "portNUD";
            this.portNUD.Size = new System.Drawing.Size(64, 20);
            this.portNUD.TabIndex = 4;
            this.portNUD.Value = new decimal(new int[] {
            8855,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP client address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // ServerSounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 111);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portNUD);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ipAddres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ServerSounds";
            this.Text = "Server Sounds";
            ((System.ComponentModel.ISupportInitialize)(this.portNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ipAddres;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.NumericUpDown portNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

