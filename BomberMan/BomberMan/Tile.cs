using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        static public Bitmap TextureWood = new Bitmap(Properties.Resources.TextureWood);
        static public Bitmap TextureEmpty = new Bitmap(Properties.Resources.TextureEmpty);
        static public Bitmap TextureBlock = new Bitmap(Properties.Resources.TextureBlock_v2);
        static public Bitmap explode = new Bitmap(Properties.Resources.exlode);
        public BLOCK_TYPE type { get; set; }
        public Rectangle Rectangle { get; set; }
        public Point Point { get; set; }
        public bool Passable { get; set; }
        public bool IsHardBlock { get; }
        public bool ContainsBomb { get; set; }
        public bool isExploded;
        public int Counter;
        public Timer time;

        public Tile(Rectangle r,Point point, bool isHardBlock, bool passable, BLOCK_TYPE bt)
        {
            Point = point;
            Rectangle = r;
            IsHardBlock = isHardBlock;
            Passable = passable;
            type = bt;
            ContainsBomb = false;
            isExploded = false;
            time = new Timer();

        }

        // Go krsi SoftBlockot 
        public void DestroyBlock()
        {
            type = BLOCK_TYPE.Empty;
            Passable = true;
            Counter = 1;
            isExploded = true;
            time.Tick += new EventHandler(timer_tick);
            time.Interval = 1000;
            time.Start();
        }

        // tick za vremetraenje na eksplozijata
        public void timer_tick(object sender, EventArgs e)
        {
            Counter--;
        }

        // iscrtuvanje na blokovite
        public void Draw(Graphics g)
        {
            if (type == BLOCK_TYPE.Empty)
            {
                if (isExploded && Counter > 0)
                {
                    g.DrawImage(explode, Rectangle);
                }
                else
                {
                    g.DrawImage(TextureEmpty, Rectangle);
                    time.Stop();
                }
            }
            else if(type ==BLOCK_TYPE.Hard)
            {
               g.DrawImage(TextureBlock, Rectangle);
            }
            else
            {
                g.DrawImage(TextureWood, Rectangle);
                if (isExploded && Counter > 0)
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
