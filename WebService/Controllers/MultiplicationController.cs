using System.Web.Http;

namespace WebService.Controllers
{
	public class MultiplicationController : ApiController
	{
		[HttpGet()]
		public double Get([FromBody]MultiplicationModel multiplicationModel)
		{
			return multiplicationModel.X * multiplicationModel.Y;
		}

		public class MultiplicationModel
		{
			public double X { get; set; }
			public double Y { get; set; }
		}
	}
}