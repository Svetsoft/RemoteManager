using RemoteManager.Sessions;

namespace RemoteManager.Extensions.TeamViewer
{
    internal class TeamViewerSession : Session
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TeamViewerSession" /> class.
        /// </summary>
        public TeamViewerSession()
        {
            Name = "TeamViewer";
        }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the password.
        /// </summary>
        /// <value>
        ///     The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        ///     Gets or sets the access.
        /// </summary>
        /// <value>
        ///     The access.
        /// </value>
        public TeamViewerAccess Access { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [always ask password].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [always ask password]; otherwise, <c>false</c>.
        /// </value>
        public bool AlwaysAskPassword { get; set; }

        /// <summary>
        ///     Gets or sets the category.
        /// </summary>
        /// <value>
        ///     The category.
        /// </value>
        public string Category { get; set; }
    }
}