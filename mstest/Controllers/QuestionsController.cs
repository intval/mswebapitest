using mstest.Interfaces;
using mstest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributeRouting.Web.Http;

namespace mstest.Controllers
{
    public class QuestionsController : ApiController
    {
        private IQuestionsRepository repo;

        public QuestionsController(IQuestionsRepository repository)
        {
            repo = repository;
        }

        // GET api/values
        [GET("bla")]
        public List<Question> Get()
        {
            return repo.getAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/values/5
        
        public void Put(Question q)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}