namespace RemoteManager.Extensions.RemoteDesktopServices
{
    public class RemoteDesktopSize
    {
        public static RemoteDesktopSize Default = new RemoteDesktopSize("Default", 0, 0);
        public static RemoteDesktopSize W640H480 = new RemoteDesktopSize("640x480", 640, 480);
        public static RemoteDesktopSize W800H600 = new RemoteDesktopSize("800x600", 800, 600);
        public static RemoteDesktopSize W1024H768 = new RemoteDesktopSize("1024x768", 1024, 768);
        public static RemoteDesktopSize W1280H720 = new RemoteDesktopSize("1280x720", 1280, 720);
        public static RemoteDesktopSize FullScreen = new RemoteDesktopSize("Full Screen", 0, 0);

        /// <summary>
        ///     Initializes a new instance of the <see cref="RemoteDesktopSize" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public RemoteDesktopSize(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
        }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; }

        /// <summary>
        ///     Gets or sets the width.
        /// </summary>
        /// <value>
        ///     The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        ///     Gets or sets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public int Height { get; set; }
    }
}