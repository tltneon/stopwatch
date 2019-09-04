/*
 * Создано в SharpDevelop.
 * Пользователь: Neon
 * Дата: 04.09.2019
 * Время: 7:20
 */
using System;
using System.Windows.Forms;

namespace stopwatch
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
