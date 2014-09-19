namespace LibGit2Sharp.Core
{
    internal class NullLogger : ILibGit2SharpLog
    {
        private NullLogger() { }

        public static readonly NullLogger Instance = new NullLogger();

        public void Debug(string messageFormat, params object[] args) { }
        public void Info(string messageFormat, params object[] args) { }
        public void Error(string messageFormat, params object[] args) { }
    }
}
