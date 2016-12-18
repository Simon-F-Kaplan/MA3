using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageAdapter
{
    public class AddABookDTO
    {
        public Guid MessageId { get; set; }
        public Guid UserId { get; set; }
        public List<Resource> Resources { get; set; }
        public DateTime MessageCreated { get; set; }
        public string MessageType { get; set; }
        public string Creator { get; set; }
        public Guid CorellationId { get; set; }

    }

    public class Resource
    {
        public string Type { get; set; }
    }
}
