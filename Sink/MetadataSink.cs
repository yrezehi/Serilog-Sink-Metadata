using Serilog.Core;
using Serilog.Events;

namespace Serilog_Sink_Metadata.Sink
{
    public class MetadataSink : ILogEventSink
    {
        private readonly IFormatProvider FormatProvider;

        public MetadataSink(IFormatProvider formatProvider) =>
            FormatProvider = formatProvider;

        public void Emit(LogEvent logEvent) =>
            logEvent.RenderMessage(FormatProvider);
    }
}
