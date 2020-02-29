using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceManagement
{
	public class WebServiceManager
	{
		private readonly int port;

		public WebServiceManager(int _port)
		{
			port = _port;
		}

		public async Task<string> GetDataFromServiceAsync(string controller, string jsonBody)
		{
			WinHttpHandler handler = new WinHttpHandler();
			HttpClient client = new HttpClient(handler);

			HttpRequestMessage request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"http://localhost:{port}/api/{controller}"),
				Content = new StringContent(jsonBody, Encoding.UTF8, "application/json")
			};

			HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
			response.EnsureSuccessStatusCode();

			string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
			client.Dispose();
			return responseBody;
		}
	}
}