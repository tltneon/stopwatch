/*
 * Создано в SharpDevelop.
 * Пользователь: Neon
 * Дата: 04.09.2019
 * Время: 7:20
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
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
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// labelM
			// 
			this.labelM.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelM.Location = new System.Drawing.Point(64, 84);
			this.labelM.Name = "labelM";
			this.labelM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.labelM.Size = new System.Drawing.Size(68, 44);
			this.labelM.TabIndex = 0;
			this.labelM.Text = "00";
			this.labelM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelS
			// 
			this.labelS.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelS.Location = new System.Drawing.Point(157, 77);
			this.labelS.Name = "labelS";
			this.labelS.Size = new System.Drawing.Size(85, 57);
			this.labelS.TabIndex = 2;
			this.labelS.Text = "00";
			this.labelS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(130, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 53);
			this.label2.TabIndex = 3;
			this.label2.Text = ":";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StartStop
			// 
			this.StartStop.ForeColor = System.Drawing.SystemColors.ControlText;
			this.StartStop.Location = new System.Drawing.Point(109, 143);
			this.StartStop.Name = "StartStop";
			this.StartStop.Size = new System.Drawing.Size(75, 23);
			this.StartStop.TabIndex = 4;
			this.StartStop.Text = "Start";
			this.StartStop.UseVisualStyleBackColor = true;
			this.StartStop.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(109, 227);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.StartStop);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelS);
			this.Controls.Add(this.labelM);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Секундомер";
			this.ResumeLayout(false);

		}
	}
}
