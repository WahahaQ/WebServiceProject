using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebService.Controllers
{
	public class ArraysController : ApiController
	{
		[HttpGet()]
		public string Get([FromBody]IEnumerable<int> numbers)
		{
			return $"Max number is {numbers.Max()} and sum of array numbers is {numbers.Sum()}.";
		}
	}
}