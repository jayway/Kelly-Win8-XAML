using System.Collections.Generic;

namespace Kelly.App
{
    public interface IVoteSetRepo
    {
        void Ensure(VoteSet voteSet);
        IEnumerable<VoteSet> AllSets { get; }
    }
}