using mstest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mstest.Interfaces
{
    public class QuestionRepository : IQuestionsRepository
    {
        static List<Question> dic = new List<Question>();

        public void Add(Question q)
        {
            dic.Add(q);
        }

        public List<Question> getAll()
        {
            return dic;
        }
    }
}