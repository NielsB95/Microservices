using System.Collections.Generic;
using System.Linq;
using Markdown.Data;
using Markdown.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Markdown.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
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
                return context.Documents
                              .Where(x => x.ID == id)
                              .FirstOrDefault();
            }
        }
    }
}
