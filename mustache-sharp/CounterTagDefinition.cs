using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Mustache
{
    internal sealed class CounterTagDefinition : InlineTagDefinition
    {
        /// <summary>
        /// Initializes a new instance of an IndexTagDefinition.
        /// </summary>
        public CounterTagDefinition()
            : base("counter", true)
        {
        }

        /// <summary>
        /// Gets the text to output.
        /// </summary>
        /// <param name="writer">The writer to write the output to.</param>
        /// <param name="arguments">The arguments passed to the tag.</param>
        /// <param name="contextScope">Extra data passed along with the context.</param>
        public override void GetText(TextWriter writer, Dictionary<string, object> arguments, Scope contextScope)
        {
            object index;
            if (contextScope.TryFind("index", out index))
            {
                writer.Write(Convert.ToInt32(index) + 1);
            }
        }
    }
}
