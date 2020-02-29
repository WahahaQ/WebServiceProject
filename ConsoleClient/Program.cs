using System;
using System.Configuration;
using System.Threading.Tasks;
using WebServiceManagement;

namespace ConsoleClient
{
	class Program
	{
		static readonly int port = int.Parse(ConfigurationManager.AppSettings["DefaultPort"]);

		static async Task Main()
		{
			try
			{
				WebServiceManager webServiceManager = new WebServiceManager(port);

				DrawInfoMessage("Test data is array[1, 3, 5]");
				Console.WriteLine(await webServiceManager.GetDataFromServiceAsync("arrays", "[1, 3, 5]"));
				Console.WriteLine();

				DrawInfoMessage("Test data is array[1, 3, 5]");
				Console.Write("Array average is ");
				Console.WriteLine(await webServiceManager.GetDataFromServiceAsync("average", "[1, 3, 5]"));
				Console.WriteLine();

				int x = 5, y = 4;
				DrawInfoMessage($"Test data is x = {x}; y = {y}");
				Console.Write($"{x}x{y}=");
				Console.WriteLine(await webServiceManager.GetDataFromServiceAsync("multiplication", "{\"x\":5,\"y\":4}"));
				Console.WriteLine();

				DrawInfoMessage("Test data is array [1, 78, 27, 3]");
				Console.Write("Array sorted in ascending order: ");
				Console.WriteLine(await webServiceManager.GetDataFromServiceAsync("sorting", "{\"numbers\": [1, 78, 27, 3],\"sortType\":0}"));
				Console.WriteLine();

				DrawInfoMessage("Test data is array [1, 78, 27, 3]");
				Console.Write("Array sorted in descending order: ");
				Console.WriteLine(await webServiceManager.GetDataFromServiceAsync("sorting", "{\"numbers\": [1, 78, 27, 3],\"sortType\":1}"));
			}
			catch
			{
				Console.Clear();
				DrawErrorMessage("Server unreachable. Please check server state");
			}

			Console.ReadKey(true);
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