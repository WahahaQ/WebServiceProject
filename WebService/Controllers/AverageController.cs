using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebService.Controllers
{
	public class AverageController : ApiController
	{
		[HttpGet()]
		public double Get([FromBody]IEnumerable<int> numbers)
		{
			return numbers.Average();
		}
	}
}