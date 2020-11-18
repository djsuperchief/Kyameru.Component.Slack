using Kyameru.Core.Contracts;
using System;
using System.Collections.Generic;

namespace Kyameru.Component.Slack
{
    /// <summary>
    /// Implementation of inflator.
    /// </summary>
    public class Inflator : IOasis
    {
        /// <summary>
        /// Creates a from component.
        /// </summary>
        /// <param name="headers">Incoming headers.</param>
        /// <returns>Returns a new instance of a <see cref="IFromComponent"/> class.</returns>
        public IFromComponent CreateFromComponent(Dictionary<string, string> headers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a to component.
        /// </summary>
        /// <param name="headers">Incoming headers.</param>
        /// <returns>Returns a new instance of a <see cref="IToComponent"/> class.</returns>
        public IToComponent CreateToComponent(Dictionary<string, string> headers)
        {
            return new SlackTo(headers);
        }
    }
}