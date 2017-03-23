using System.Collections.Generic;

namespace _06.Messages
{
    public class User
    {
        public string UserName { get; set; }

        public List<string> ReceivedMessages { get; set; }
    }
}
