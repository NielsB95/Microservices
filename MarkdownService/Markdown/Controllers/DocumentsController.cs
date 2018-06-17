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
                              .Select(x => new Document
                              {
                                  ID = x.ID,
                                  Title = x.Title,
                                  CreatedAt = x.CreatedAt
                              })
                              .ToList();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Document> Get(Guid id)
        {
            using (var context = new MarkdownContext())
            {
                return context.Documents
                               .Where(x => x.ID.ToString().Equals(id.ToString()))
                               .ToList()
                               .FirstOrDefault();
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Document> PostDocument(Document document)
        {
            using (var context = new MarkdownContext())
            {
                // context.Documents.Update(document);

                return document;
            }
        }
    }
}