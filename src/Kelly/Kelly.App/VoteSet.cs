using System;
using System.Runtime.Serialization;

namespace Kelly.App
{
    [DataContract]
    public class VoteSet
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public DateTime StartTime { get; set; }

        [DataMember]
        public DateTime EndTime { get; set; }

        [DataMember]
        public bool HasEnded { get; set; }

        [DataMember]
        public int RedCount { get; set; }

        [DataMember]
        public int YellowCount { get; set; }

        [DataMember]
        public int GreenCount { get; set; }
    }
}