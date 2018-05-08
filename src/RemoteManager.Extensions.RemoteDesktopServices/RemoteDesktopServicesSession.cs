using RemoteManager.Sessions;

namespace RemoteManager.Extensions.RemoteDesktopServices
{
    internal class RemoteDesktopServicesSession : Session
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoteDesktopServicesSession" /> class.
        /// </summary>
        public RemoteDesktopServicesSession()
        {
            Name = "Microsoft Remote Desktop (RDP)";
        }

        /// <summary>
        ///     Gets or sets the computer.
        /// </summary>
        /// <value>
        ///     The computer.
        /// </value>
        public string Computer { get; set; }

        /// <summary>
        ///     Gets or sets the port.
        /// </summary>
        /// <value>
        ///     The port.
        /// </value>
        public int Port { get; set; }

        /// <summary>
        ///     Gets or sets the username.
        /// </summary>
        /// <value>
        ///     The username.
        /// </value>
        public string Username { get; set; }

        /// <summary>
        ///     Gets or sets the password.
        /// </summary>
        /// <value>
        ///     The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [open console].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [open console]; otherwise, <c>false</c>.
        /// </value>
        public bool OpenConsole { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [always ask credentials].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [always ask credentials]; otherwise, <c>false</c>.
        /// </value>
        public bool AlwaysAskCredentials { get; set; }

        /// <summary>
        ///     Gets or sets the category.
        /// </summary>
        /// <value>
        ///     The category.
        /// </value>
        public string Category { get; set; }
    }
}