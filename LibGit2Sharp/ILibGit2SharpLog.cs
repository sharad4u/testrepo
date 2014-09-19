namespace LibGit2Sharp
{
    public interface ILibGit2SharpLog
    {
        void Debug(string messageFormat, params object[] args);
        void Info(string messageFormat, params object[] args);
        void Error(string messageFormat, params object[] args);
    }
}
