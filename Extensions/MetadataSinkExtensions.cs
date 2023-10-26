using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog_Sink_Metadata.Sink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog_Sink_Metadata.Extensions
{
    public static class MetadataSinkExtensions
    {
        public static LoggerConfiguration MetadataSink(this LoggerSinkConfiguration configuration, IFormatProvider formatProvider) =>
            configuration.Sink(new MetadataSink(formatProvider));
    }
}
