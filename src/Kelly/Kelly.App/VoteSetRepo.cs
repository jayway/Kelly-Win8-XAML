using System;
using System.Collections.Generic;

namespace Kelly.App
{
    public class VoteSetRepo : IVoteSetRepo
    {
        public static IVoteSetRepo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VoteSetRepo();
                }
                return _instance;
            }
        }

        private VoteSetRepo()
        {
            _sets = new Dictionary<DateTime, VoteSet>();
        }

        public void Ensure(VoteSet voteSet)
        {
            var setToAdd = voteSet.GetClone();
            if (_sets.ContainsKey(setToAdd.StartTime))
            {
                _sets.Remove(setToAdd.StartTime);
            }
            _sets.Add(setToAdd.StartTime, setToAdd);
        }

        public IEnumerable<VoteSet> AllSets { get { return _sets.Values; } }

        private readonly Dictionary<DateTime, VoteSet> _sets;
        private static VoteSetRepo _instance;
    }
}