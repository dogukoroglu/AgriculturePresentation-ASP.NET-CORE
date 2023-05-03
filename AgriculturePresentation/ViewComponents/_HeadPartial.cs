using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _HeadPartial:ViewComponent
	{
		public IViewComponentResult Invoke() // Invoke bir isimlendirme standartıdır.
		{
			return View();	
		}
	}
}
