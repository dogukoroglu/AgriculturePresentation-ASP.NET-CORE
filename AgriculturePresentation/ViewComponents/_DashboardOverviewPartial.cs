using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _DashboardOverviewPartial:ViewComponent
	{
		AgricultureContext c = new AgricultureContext();
		public IViewComponentResult Invoke()
		{
			DateTime dt = DateTime.Now;
			ViewBag.teamCount = c.Teams.Count();
			ViewBag.serviceCount = c.Services.Count();
			ViewBag.messageCount = c.Contacts.Count();
			ViewBag.currentMonthMessage = c.Contacts.Where(x => x.Date.Month == dt.Month).Count();

			ViewBag.announcementTrue = c.Announcements.Where(x => x.Status == true).Count();
			ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

			ViewBag.yazilimGelistirici = c.Teams.Where(x => x.Title == "Back-End Yazılım Geliştirici").Select(y=>y.PersonName).FirstOrDefault();
			ViewBag.insanKaynaklari = c.Teams.Where(x => x.Title == "İnsan Kaynakları").Select(y=>y.PersonName).FirstOrDefault();
			ViewBag.finansMuduru = c.Teams.Where(x => x.Title == "Finans Müdürü").Select(y=>y.PersonName).FirstOrDefault();
			ViewBag.satisMuduru = c.Teams.Where(x => x.Title == "Satış Müdürü").Select(y=>y.PersonName).FirstOrDefault();

			return View();
		}
	}
}
