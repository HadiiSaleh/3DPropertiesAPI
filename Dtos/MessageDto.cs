using System;

namespace _3DPropertiesAPI.Dtos
{
    public class MessageDto
    {
        public int Id { get; set; }

        public string Sender { get; set; }

        public string SenderRole { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public bool Read { get; set; }

        public bool Deleted { get; set; }

        public DateTime Date { get; set; }
    }
}
