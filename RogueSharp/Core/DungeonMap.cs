using System;
using RLNET;

namespace RogueSharp.Core
{
    public class DungeonMap : Map
    {
        // The draw method will be called each time the map is updated
        // It will render all of the symbols/colors for each cell to the map
        // sub-console
        public void Draw(RLConsole mapConsole)
        {
            mapConsole.Clear();
            foreach (Cell cell in GetAllCells() )
            {
                SetConsoleSymbolForCell(mapConsole, cell);
            }
        }

        private void SetConsoleSymbolForCell(RLConsole mapConsole, Cell cell)
        {
            // If cell not explored, don't draw anything
            if(!cell.IsExplored)
            {
                return;
            }

            // when a cell is currently in FOV, it should be drawn with lighter
            // colors
            if (IsInFov(cell.X, cell.Y))
            {
                // Choose the symbol to use if the cell is walkable or not
                // "." for floor and "#" for walls
            }
        }
    }
}
