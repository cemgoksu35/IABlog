﻿using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
        void CommentAdd(Comment comment);
        List<Comment> GetList(int id);
    }
}

