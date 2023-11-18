using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents.Writer
{
	public class WriterMessageNotification : ViewComponent
	{
       
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

