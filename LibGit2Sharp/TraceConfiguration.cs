using System;
using LibGit2Sharp.Core;
using LibGit2Sharp.Handlers;

namespace LibGit2Sharp
{
    /// <summary>
    /// Tracing configuration for libgit2 and LibGit2Sharp.
    /// </summary>
    public class TraceConfiguration
    {
        /// <summary>
        /// The default tracing configuration, which performs no tracing at all.
        /// </summary>
        public static readonly TraceConfiguration None = new TraceConfiguration { Level = TraceLevel.None };

        /// <summary>
        /// Creates a new tracing configuration to call the given
        /// delegate when tracing occurs at the given level.
        /// </summary>
        /// <param name="level">Level to trace at</param>
        /// <param name="handler">Handler to call when tracing occurs</param>
        public TraceConfiguration(TraceLevel level, TraceHandler handler)
        {
            Ensure.ArgumentConformsTo<TraceLevel>(level, (t) => { return (level != TraceLevel.None); }, "level");
            Ensure.ArgumentNotNull(handler, "handler");

            Level = level;
            Handler = handler;
        }

        protected TraceConfiguration()
        {
        }

        internal TraceLevel Level { get; private set; }
        internal TraceHandler Handler { get; set; }

        internal void GitTraceHandler(TraceLevel level, IntPtr msg)
        {
            string message = LaxUtf8Marshaler.FromNative(msg);
            Handler(level, message);
        }
    }
}
