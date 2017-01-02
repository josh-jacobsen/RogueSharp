using RLNET;

namespace RogueSharp
{
    public class Game
    {
        // height and width are in number of tiles 
        private static readonly int _screenWidth = 100;
        private static readonly int _screeenHeight = 70;
        private static RLRootConsole _rootConsole;

        // the map console takes up most of the screen and is where the map will be drawn
        private static readonly int _mapWidth = 80;
        private static readonly int _mapHeight = 48;
        private static RLConsole _mapConsole;

        // below the map is the message console which displays attack rolls and other information
        private static readonly int _messageWidth = 80;
        private static readonly int _messageHeight = 11;
        private static RLConsole _messageConsole;

        // the stat console is to the right and displays player and monster stats 
        private static readonly int _statWidth = 20;
        private static readonly int _statHeight = 70;
        private static RLConsole _statConsole;

        // above the map is the inventory console that displays the players equipment, abilities, and items
        private static readonly int _inventoryWidth = 80;
        private static readonly int _inventoryHeight = 11;
        private static RLConsole _inventoryConsole;

        public static void Main(string[] args)
        {
            // This must be the exact name of the bitmap font file
            // we are using or it will error.
            string fontFileName = "terminal8x8.png";
            // The title will appear at the top of the console
            // window
            string consoleTitle = "RogueSharp V3 Tutorial - Level 1";
            // Tell RLNet to use the bitmap font that we specified
            // and that each tile is 8 x 8 pixels
            _rootConsole = new RLRootConsole(fontFileName, _screenWidth, _screeenHeight, 8, 8, 1f, consoleTitle);

            // initilize the subconsoles to Blit to root console
            _mapConsole = new RLConsole(_mapWidth, _mapHeight);
            _messageConsole = new RLConsole(_messageWidth, _messageHeight);
            _statConsole = new RLConsole(_statWidth, _statHeight);
            _inventoryConsole = new RLConsole(_inventoryWidth, _inventoryHeight);

            // Set up a handler for RLNET's Update event
            _rootConsole.Update += OnRootConsoleUpdate;
            // Set up a handler for RLNET's Render event
            _rootConsole.Render += OnRootConsoleRender;
            // Begin RLNET's game loop
            _rootConsole.Run();
        }

        // Event handler for RLNET's Update event
        private static void OnRootConsoleUpdate(object sender, UpdateEventArgs e)
        {
            _rootConsole.Print(10, 10, "It worked!!", RLColor.White);
        }

        // Event handler for RLNET's Render event
        private static void OnRootConsoleRender(object sender, UpdateEventArgs e)
        {
            // Tell RLNET to draw the console that we set
            _rootConsole.Draw();
        }

    }
}
