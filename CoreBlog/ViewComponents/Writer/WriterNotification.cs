using System;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Writer
{
	public class WriterNotification : ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

