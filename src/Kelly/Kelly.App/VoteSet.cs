using System;
using System.Runtime.Serialization;
using Kelly.App.Resources;

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

        public string IsRunningText { get { return !HasEnded ? Res.Instance.GetString("IsRunningText") : string.Empty;  } }

        public void EndNow()
        {
            EndTime = DateTime.Now;
            HasEnded = true;
        }
    }
}