using System.Collections.Generic;
using System.Linq;
using Markdown.Data;
using Markdown.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Markdown.Controllers
{
    [Route("[controller]")]
    public class DocumentsController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Document>> Get()
        {
            using (var context = new MarkdownContext())
            {
                return context.Documents
                              .ToList();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Document> Get(Guid id)
        {
            using (var context = new MarkdownContext())
            {
                var y = context.Documents
                               .Where(x => x.ID.ToString().Equals(id.ToString()))
                               .ToList()
                               .FirstOrDefault();
                return y;
            }
        }
    }
}
