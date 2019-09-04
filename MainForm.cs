/*
 * Создано в SharpDevelop.
 * Пользователь: Neon
 * Дата: 04.09.2019
 * Время: 7:20
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace stopwatch
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int timeMS, timeM, timeS;
		bool isActive;
		public MainForm()
		{
			InitializeComponent();
		}
		void DrawTime(){
			labelMS.Text = (timeMS<10 ? "0":"") + timeMS.ToString();
			labelM.Text = (timeM<10 ? "0":"") + timeM.ToString();
			labelS.Text = (timeS<10 ? "0":"") + timeS.ToString();
		}
		void ResetTime(){
			timeMS = 0;
			timeM = 0;
			timeS = 0;
			StartStop.Text = "Start";
			isActive = false;
			DrawTime();
		}
		void Button1Click(object sender, EventArgs e) //start-stop button
		{
			if(isActive){
				StartStop.Text = "Start";
				isActive = false;
			}
			else{
				StartStop.Text = "Stop";
				isActive = true;
			}
		}
		void Button2Click(object sender, EventArgs e) //reset button
		{
			ResetTime();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if(isActive){
				timeMS++;
				if(timeMS > 99){
					timeMS = 0;
					timeS++;
					if(timeS > 59){
						timeS = 0;
						timeM++;
					}
				}
			}
			DrawTime();
		}
	}
}
