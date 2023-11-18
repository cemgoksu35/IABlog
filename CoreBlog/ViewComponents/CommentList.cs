using System;
using CoreBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.ViewComponents
{
	public class CommentList: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					Id=1,
					UserName="cemcan"
				},
				new UserComment
				{
					Id=2,
					UserName="aslan"
				},
				new UserComment
				{
					Id=3,
					UserName="volkan"
				}
			};
			return View(commentvalues);
		}
	}
}

