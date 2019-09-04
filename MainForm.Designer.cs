/*
 * Создано в SharpDevelop.
 * Пользователь: Neon
 * Дата: 04.09.2019
 * Время: 7:20
 */
namespace stopwatch
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label labelM;
		private System.Windows.Forms.Label labelS;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button StartStop;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label labelMS;
		private System.Windows.Forms.Label label3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.labelM = new System.Windows.Forms.Label();
			this.labelS = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.StartStop = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.labelMS = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// labelM
			// 
			this.labelM.Font = new System.Drawing.Font("Verdana", 45F, System.Drawing.FontStyle.Bold);
			this.labelM.Location = new System.Drawing.Point(2, 67);
			this.labelM.Name = "labelM";
			this.labelM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.labelM.Size = new System.Drawing.Size(119, 76);
			this.labelM.TabIndex = 0;
			this.labelM.Text = "00";
			this.labelM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelS
			// 
			this.labelS.Font = new System.Drawing.Font("Verdana", 45F, System.Drawing.FontStyle.Bold);
			this.labelS.Location = new System.Drawing.Point(109, 67);
			this.labelS.Name = "labelS";
			this.labelS.Size = new System.Drawing.Size(118, 77);
			this.labelS.TabIndex = 2;
			this.labelS.Text = "00";
			this.labelS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(102, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 53);
			this.label2.TabIndex = 3;
			this.label2.Text = ":";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StartStop
			// 
			this.StartStop.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StartStop.ForeColor = System.Drawing.SystemColors.ControlText;
			this.StartStop.Location = new System.Drawing.Point(35, 184);
			this.StartStop.Name = "StartStop";
			this.StartStop.Size = new System.Drawing.Size(84, 42);
			this.StartStop.TabIndex = 4;
			this.StartStop.Text = "Start";
			this.StartStop.UseVisualStyleBackColor = true;
			this.StartStop.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(167, 184);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 42);
			this.button2.TabIndex = 5;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// labelMS
			// 
			this.labelMS.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
			this.labelMS.Location = new System.Drawing.Point(215, 97);
			this.labelMS.Name = "labelMS";
			this.labelMS.Size = new System.Drawing.Size(69, 37);
			this.labelMS.TabIndex = 6;
			this.labelMS.Text = "00";
			this.labelMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(208, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 41);
			this.label3.TabIndex = 7;
			this.label3.Text = ".";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelMS);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.StartStop);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelS);
			this.Controls.Add(this.labelM);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Секундомер";
			this.ResumeLayout(false);
		}
	}
}