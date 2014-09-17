using System;
using LibGit2Sharp;
using LibGit2Sharp.Core;
using Xunit;

namespace LibGit2Sharp.Tests
{
    public class TraceFixture
    {
        [Fact]
        public void CanEnableAndDisableTracing()
        {
            TraceLevel level = TraceLevel.None;
            string message = null;

            GlobalSettings.TraceConfiguration = new TraceConfiguration(TraceLevel.Info, (l, m) => { level = l; message = m; });
            Trace.Write(TraceLevel.Info, "This is an informative trace.");

            Assert.Equal(TraceLevel.Info, level);
            Assert.Equal("This is an informative trace.", message);

            level = TraceLevel.None;
            message = null;

            GlobalSettings.TraceConfiguration = TraceConfiguration.None;
            Trace.Write(TraceLevel.Error, "This will not be traced since tracing is disabled.");

            Assert.Equal(TraceLevel.None, level);
            Assert.Equal(null, message);
        }

        [Fact]
        public void CanEasilyDetermineIfTracingIsEnabled()
        {
            GlobalSettings.TraceConfiguration = new TraceConfiguration(TraceLevel.Info, (l, m) => { });

            Assert.Equal(true, Trace.IsEnabled(TraceLevel.Fatal));
            Assert.Equal(true, Trace.IsEnabled(TraceLevel.Error));
            Assert.Equal(true, Trace.IsEnabled(TraceLevel.Warning));
            Assert.Equal(true, Trace.IsEnabled(TraceLevel.Info));
            Assert.Equal(false, Trace.IsEnabled(TraceLevel.Debug));
            Assert.Equal(false, Trace.IsEnabled(TraceLevel.Trace));

            GlobalSettings.TraceConfiguration = TraceConfiguration.None;

            Assert.Equal(false, Trace.IsEnabled(TraceLevel.Fatal));
            Assert.Equal(false, Trace.IsEnabled(TraceLevel.Error));
            Assert.Equal(false, Trace.IsEnabled(TraceLevel.Warning));
            Assert.Equal(false, Trace.IsEnabled(TraceLevel.Info));
            Assert.Equal(false, Trace.IsEnabled(TraceLevel.Debug));
            Assert.Equal(false, Trace.IsEnabled(TraceLevel.Trace));
        }
    }
}
