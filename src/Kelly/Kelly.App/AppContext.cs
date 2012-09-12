namespace Kelly.App
{
    public static class AppContext
    {
        private static string _voteTitle;
        public static string VoteTitle
        {
            get { return _voteTitle; }
            set { _voteTitle = value; }
        }
    }
}
