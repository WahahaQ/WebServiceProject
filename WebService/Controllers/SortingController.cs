using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebService.Controllers
{
	public class SortingController : ApiController
	{
		[HttpGet()]
		public IEnumerable<int> Get([FromBody]SortModel sortModel)
		{
			switch (sortModel.SortType)
			{
				case SortType.Ascending:
					return sortModel.Numbers.OrderBy(x => x);
				case SortType.Descending:
					return sortModel.Numbers.OrderByDescending(x => x);
				default:
					return null;
			}
		}
	}

	public class SortModel
	{
		public IEnumerable<int> Numbers { get; set; }
		public SortType SortType { get; set; }
	}

	public enum SortType
	{
		Ascending, Descending
	}
}