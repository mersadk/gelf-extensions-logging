﻿using Xunit;

namespace Gelf.Extensions.Logging.Tests
{
    public class HttpGelfLoggerTests : GelfLoggerTests, IClassFixture<HttpGraylogFixture>
    {
        public HttpGelfLoggerTests(HttpGraylogFixture graylogFixture) : base(graylogFixture,
            new LoggerFixture(new GelfLoggerOptions
            {
                Host = GraylogFixture.GraylogHost,
                Port = graylogFixture.InputPort,
                Protocol = GelfProtocol.Http,
                LogSource = typeof(HttpGelfLoggerTests).Name
            }))
        {
        }
    }
}
