using System;
using System.Collections.Generic;

namespace Kelly.App
{
    public class VoteSetRepo
    {
        public VoteSetRepo()
        {
            _sets = new Dictionary<DateTime, VoteSet>();
        }

        public void Ensure(VoteSet voteSet)
        {
            if (_sets.ContainsKey(voteSet.StartTime))
            {
                _sets.Remove(voteSet.StartTime);
            }
            _sets.Add(voteSet.StartTime, voteSet);
        }

        public IEnumerable<VoteSet> AllSets { get { return _sets.Values; } }

        private readonly Dictionary<DateTime, VoteSet> _sets;
    }
}