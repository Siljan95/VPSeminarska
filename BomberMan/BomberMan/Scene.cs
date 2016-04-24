using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BomberMan
{
    class Scene
    {
        public List<BomberMan> BomberMen;
        //The map has to be a Hash because we have to have constant checking
        public Tile[,] Map { get; set; }

        public Scene()
        {
            BomberMen = new List<BomberMan>();
            Map = new Tile[11, 11];
        }

        public void AddPlayer(BomberMan bomberMan)
        {
            BomberMen.Add(bomberMan);
        }

        //public void AddTilesToMap(Point p, Tile tile)
        //{
        //    Map.Add(p, tile);
        //}

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
                        t = new Tile(r, point, true, false, Color.DarkBlue);
                        Map[i, j] = t;

                    }
                    else
                    {
                        randomInt = rand.Next(0, 2);
                        if (randomInt == 1)
                        {
                            if (generateSoftBlocks(i, j, 11, 11))
                            {
                                t = new Tile(r, point, false, false, Color.LightGray);
                                Map[i, j] = t;
                            }
                            else
                            {
                                t = new Tile(r, point, false, true, Color.GreenYellow);//Moze da se trgne ova i da se napravi neso so continue
                                Map[i, j] = t;
                            }
                        }
                        else
                        {
                            t = new Tile(r, point, false, true, Color.GreenYellow);
                            Map[i, j] = t;
                        }
                    }
                   // point = t.Center;
                    //Map.Add(point, t);
                    //AddTilesToMap(t);
                }
            }
        }

        public void DrawMap(Graphics g)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Map[i,j].Draw(g);
                }
            }
        }

        public void Count()
        {
            foreach (BomberMan b in BomberMen)
            {
                foreach (KeyValuePair<Point, Bomb> bomb in b.Bombs)
                {
                    bomb.Value.CountDown -= 1;
                }
            }
        }

        public void Draw(Graphics g)
        {
            bool flag = false;
            Point key = new Point();
            foreach (BomberMan b in BomberMen)
            {
                b.Draw(g);
                foreach(KeyValuePair<Point, Bomb> bomb in b.Bombs)
                {
                    flag = bomb.Value.Explode(g);
                    if (flag)
                    {
                        key = bomb.Value.Cordinates;
                    }
                }
                if (flag)
                {
                    flag = false;
                    b.Bombs.Remove(key);
                }
            }
        }

        public void MovePlayer(List<Keys> keys)
        {
            foreach (BomberMan b in BomberMen)
            {
                foreach (Keys k in keys)
                {
                    if (k == b.CommandUp)
                    {
                        b.ChangeDirection(BomberMan.DIRECTION.UP);
                        //If states for checking if the player can move to that tile
                        if (b.canPass(Map))
                        {
                            b.Move();
                        }
                    }
                    if (k == b.CommandDown)
                    {
                        b.ChangeDirection(BomberMan.DIRECTION.DOWN);
                        if (b.canPass(Map))
                            b.Move();
                    }
                    if (k == b.CommandRight)
                    {
                        b.ChangeDirection(BomberMan.DIRECTION.RIGHT);
                        if (b.canPass(Map))
                            b.Move();
                    }
                    if (k == b.CommandLeft)
                    {
                        b.ChangeDirection(BomberMan.DIRECTION.LEFT);
                        if (b.canPass(Map))
                            b.Move();
                    }
                    if (k == b.CommandPutBomb)
                    {
                        b.PlaceBomb(Map);
                    }
                }
            }
        }
    }
}
