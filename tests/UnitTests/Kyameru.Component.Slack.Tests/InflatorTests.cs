using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Kyameru.Component.Slack.Tests
{
    [TestFixture]
    public class InflatorTests
    {
        [Test]
        public void ActivateToWorks()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "Target", "test" },
                { "MessageSource", "Body" }
            };
            Slack.Inflator inflator = new Inflator();
            Assert.NotNull(inflator.CreateToComponent(headers));
        }

        [Test]
        public void ActivateFromThrows()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "Target", "test" }
            };
            Slack.Inflator inflator = new Inflator();
            Assert.Throws<NotImplementedException>(() => { inflator.CreateFromComponent(headers); });
        }
    }
}