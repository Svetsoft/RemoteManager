using System.Collections.Generic;

namespace RemoteManager.Sessions
{
    public class Entry : IEntry
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Entry" /> class.
        /// </summary>
        public Entry()
        {
            DataSources = new HashSet<IDataSource>();
        }

        /// <summary>
        ///     Gets or sets the data sources.
        /// </summary>
        /// <value>
        ///     The data sources.
        /// </value>
        public ICollection<IDataSource> DataSources { get; set; }

        /// <inheritdoc />
        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; protected set; }
    }
}