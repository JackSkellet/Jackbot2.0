using System;

namespace jack.Wrappers
{
    public class Wrapper
    {
        public bool IsEnabled { get; set; }
        public ulong TextChannel { get; set; }
    }

    public class Error
    {
        public bool OnOff { get; set; }
    }

    public class joinrole
    {
        public bool IsEnabled { get; set; }
        public ulong roleid { get; set; }
    }

    public class music
    {

        public string name { get; set; }
        public DateTime added { get; set; }
        public string duration { get; set; }
        public double seconds { get; set; }
        public string thumbnail { get; set; }
    }
}
