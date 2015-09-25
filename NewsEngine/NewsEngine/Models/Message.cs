using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsEngine.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual ICollection<Reply> Replies { get; set; } = new List<Reply>();
        public string Text2 { get; set; }
    }
}