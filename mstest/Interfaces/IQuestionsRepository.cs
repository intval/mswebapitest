using mstest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mstest.Interfaces
{
    public interface IQuestionsRepository
    {
        List<Question> getAll();
        void Add(Question q);
    }
}