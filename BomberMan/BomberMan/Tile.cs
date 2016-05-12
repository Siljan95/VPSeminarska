using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    public class Tile
    {
        public enum BLOCK_TYPE
        {
            Hard,
            Soft,
            Empty
        }

        /// <summary>
        /// Image for the Soft Block
        /// </summary>
        static public Bitmap TextureWood = new Bitmap(Properties.Resources.TextureWood);

        /// <summary>
        /// Image for the Empty Block
        /// </summary>
        static public Bitmap TextureEmpty = new Bitmap(Properties.Resources.TextureEmpty);

        /// <summary>
        /// Image for the hard block
        /// </summary>
        static public Bitmap TextureBlock = new Bitmap(Properties.Resources.TextureBlock_v2);

        /// <summary>
        /// Image for when the block is exploded
        /// </summary>
        static public Bitmap explode = new Bitmap(Properties.Resources.exlode);

        /// <summary>
        /// Type of the block
        /// </summary>
        public BLOCK_TYPE type { get; set; }

        /// <summary>
        /// The frame of the tile
        /// </summary>
        public Rectangle Rectangle { get; set; }

        /// <summary>
        /// Tells if the block is passable
        /// </summary>
        public bool IsPassable { get; set; }

        /// <summary>
        /// Tells if the block contains a bomb
        /// </summary>
        public bool ContainsBomb { get; set; }

        /// <summary>
        /// Keeps track of the player who placed the bomb on the tile
        /// </summary>
        public BomberMan WhoPlaced { get; set; }

        /// <summary>
        /// Counter for when the bomb is Exploded. It is used to display how long the 
        /// explosion would stay on the tile
        /// </summary>
        public int Counter;
        public Timer time;

        /// <summary>
        /// Constructor for the Tile. Initilazing the frame for the tile, 
        /// Boolean that tells if the block is passable, and the type of the block
        /// </summary>
        /// <param name="r">Frame for the block</param>
        /// <param name="passable">Is it passable</param>
        /// <param name="bt">Type of the block</param>
        public Tile(Rectangle rectangle, bool passable, BLOCK_TYPE bt)
        {
            Rectangle = rectangle;
            IsPassable = passable;
            type = bt;
            ContainsBomb = false;
            time = new Timer();
        }

        /// <summary>
        /// Destroys the soft block
        /// </summary>
        public void DestroyBlock()
        {
            type = BLOCK_TYPE.Empty;
            IsPassable = true;
            ContainsBomb = false;
            Counter = 1;
            time.Tick += new EventHandler(timer_tick);
            time.Interval = 1000;
            time.Start();
        }
        public void CreateHardBlock()
        {
            type = BLOCK_TYPE.Hard;
            IsPassable = false;
            ContainsBomb = false;

        }

        /// <summary>
        /// Timer for the count 
        /// </summary>
        public void timer_tick(object sender, EventArgs e)
        {
            Counter--;
        }

        /// <summary>
        /// Draws the tiles
        /// </summary>
        /// <param name="g">Grapics argument that is used for drawing the tile</param>
        public void Draw(Graphics g)
        {
            if (type == BLOCK_TYPE.Empty)
            {
                if (Counter > 0)
                {
                    g.DrawImage(explode, Rectangle);
                }
                else
                {
                    g.DrawImage(TextureEmpty, Rectangle);
                    time.Stop();
                }
            }
            else if (type == BLOCK_TYPE.Hard)
            {
                g.DrawImage(TextureBlock, Rectangle);
            }
            else
            {
                g.DrawImage(TextureWood, Rectangle);
                if (Counter > 0)
                {
                    g.DrawImage(explode, Rectangle);
                }
                else
                {
                    time.Stop();
                }
            }
        }
    }
}
