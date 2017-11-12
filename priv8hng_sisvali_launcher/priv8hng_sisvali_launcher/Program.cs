using System;
using System.Windows.Forms;

namespace priv8hng_sisvali_launcher
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new w_main());
		}
	}
}
