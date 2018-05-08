namespace RemoteManager.Sessions
{
    public class DataSource : IEntity, IDataSource
    {
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