using Microsoft.Owin.Hosting;
using System;
using System.Configuration;
using System.Threading;
using WebService;

namespace WebServiceConsoleHost
{
	class Program
	{
		static readonly int port = int.Parse(ConfigurationManager.AppSettings["DefaultPort"]);

		static void Main(string[] args)
		{
			try
			{
				string baseAddress = $"http://*:{port}/";
				using (WebApp.Start<Startup>(url: baseAddress))
				{
					DrawInfoMessage("Server has started");
					Thread.Sleep(Timeout.Infinite);
				}
			}
			catch
			{
				DrawErrorMessage("Access denied");
			}
		}

		static void DrawInfoMessage(string message)
		{
			DrawMessage(ConsoleColor.Blue, "Info", message);
		}

		static void DrawErrorMessage(string message)
		{
			DrawMessage(ConsoleColor.Red, "Error", message);
		}

		static void DrawMessage(ConsoleColor color, string messageType, string message)
		{
			Console.ForegroundColor = color;
			Console.Write($"[{messageType}] ");
			Console.ResetColor();

			Console.WriteLine(message);
		}
	}
}