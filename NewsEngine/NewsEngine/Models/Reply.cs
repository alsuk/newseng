using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsEngine.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
        public virtual Message Message { get; set; }
        public int MessageId { get; set; }
    }
}