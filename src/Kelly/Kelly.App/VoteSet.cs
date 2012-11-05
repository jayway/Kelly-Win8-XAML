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

        public string EndTimeString { get { return !HasEnded ? Res.Instance.GetString("IsRunningText") : EndTime.ToString(); } }

        public void EndNow()
        {
            EndTime = DateTime.Now;
            HasEnded = true;
        }

        public VoteSet GetClone()
        {
            return MemberwiseClone() as VoteSet;
        }
    }
}