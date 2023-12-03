﻿using System;
using System.Windows.Forms;


namespace ASTM_Test;

internal static class Program
{
	/// <summary>
	///     The main entry point for the application.
	/// </summary>
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(mainForm: new frmMain());
	}
}