using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    class Map
    {
        public Dictionary<Point, Tile> Tiles { get; set; }
        public Item[] Items { get; set; }

        public Map()
        {
            Tiles = new Dictionary<Point, Tile>();
            Items = new Item[0];
        }

        public void AddTiles(Point p, Tile t)
        {
            Tiles.Add(p, t);
        }

        public bool generateHardBlocks(int i, int j)
        {
            if ((i % 2 == 0 && j % 2 == 0) || (j == 0) || (i == 0) || (i == 10) || (j == 10))
            {
                return true;
            }
            return false;
        }


        public bool generateSoftBlocks(int i, int j, int m, int n)
        {
            if ((i == 1 && j == 1) || (i == 1 && j == 2) || (i == 2 && j == 1))
                return false;
            else if ((i == 1 && j == n - 2) || (i == 1 && j == n - 3) || (i == 2 && j == n - 2))
                return false;
            else if ((i == m - 2 && j == 1) || (i == m - 3 && j == 1) || (i == m - 2 && j == 2))
                return false;
            else if ((i == m - 2 && j == n - 2) || (i == m - 2 && j == n - 3) || (i == m - 3 && j == n - 2))
                return false;
            return true;
        }

        public void GenerateMap()
        {
            Tile t;
            Point point;
            Rectangle r;
            Random rand = new Random();
            int randomInt;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    point = new Point((i * 50), (j * 50));

                    r = new Rectangle(point, new Size(50, 50));
                    if (generateHardBlocks(i, j))
                    {
                        t = new Tile(r, point, true, false, Tile.BLOCK_TYPE.Hard);
                    }
                    else
                    {
                        randomInt = rand.Next(0, 3);
                        if ((randomInt == 0 || randomInt == 1) && generateSoftBlocks(i, j, 11, 11))
                        {
                            t = new Tile(r, point, false, false, Tile.BLOCK_TYPE.Soft);
                        }
                        else
                        {
                            t = new Tile(r, point, false, true, Tile.BLOCK_TYPE.Empty);
                        }
                    }
                    AddTiles(point, t);
                }
            }
        }

        public void DestroyBlock(Point location)
        {
            Tiles[location].DestroyBlock();
            GenerateItem(location);
        }

        public void GenerateItem(Point location)
        {
            Random rand = new Random();
            int randInt = rand.Next(0, 5);
            if (randInt == 0)
            {
                Item i = new SpeedUpItem(location);
            }
            else if (randInt == 1)
            {
                Item i = new IncraseBombsItem(location);
            }
            else if(randInt == 2)
            {
                Item i = new IncreaseRadiusItem(location);
            }
        }

        public void Draw(Graphics g)
        {
            foreach (KeyValuePair<Point, Tile> tile in Tiles)
            {
                tile.Value.Draw(g);
            }
        }

    }
}
