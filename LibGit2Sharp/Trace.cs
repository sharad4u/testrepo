using System.Runtime.CompilerServices;
using LibGit2Sharp.Core;

[assembly: InternalsVisibleTo("LibGit2Sharp.Tests")]
namespace LibGit2Sharp
{
    internal class Trace
    {
        internal static bool IsEnabled(TraceLevel level)
        {
            TraceConfiguration configuration = GlobalSettings.TraceConfiguration;

            return (configuration.Level != TraceLevel.None && configuration.Level >= level);
        }

        internal static void Write(TraceLevel level, string message)
        {
            TraceConfiguration configuration = GlobalSettings.TraceConfiguration;

            if (configuration.Level != TraceLevel.None && configuration.Level >= level)
            {
                configuration.Handler(level, message);
            }
        }
    }
}
