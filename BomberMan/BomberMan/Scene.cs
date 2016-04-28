using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BomberMan
{
    class Scene
    {
        public List<BomberMan> BomberMen;
        public Dictionary<Point, Tile> Map { get; set; }
        

        public Scene()
        {
            BomberMen = new List<BomberMan>();
            Map = new Dictionary<Point, Tile>();
        }

        public void AddPlayer(BomberMan bomberMan)
        {
            BomberMen.Add(bomberMan);
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
                        randomInt = rand.Next(0, 2);
                        if (randomInt == 1 && generateSoftBlocks(i, j, 11, 11))
                        {
                            t = new Tile(r, point, false, false, Tile.BLOCK_TYPE.Soft);
                        }
                        else
                        {
                            t = new Tile(r, point, false, true, Tile.BLOCK_TYPE.Empty);
                        }
                    }
                    Map.Add(point, t);
                }
            }
        }

        public void DrawMap(Graphics g)
        {
            foreach (KeyValuePair<Point, Tile> tile in Map)
            {
                tile.Value.Draw(g);
            }
        }

        public void Count()
        {
            bool flag = false;
            List<BomberMan> temp = new List<BomberMan>();
            List<Bomb> tempBomb = new List<Bomb>();
            foreach (BomberMan b in BomberMen)
            {
                foreach (Bomb bomb in b.Bombs)
                {
                    bomb.CountDown -= 1;
                    flag = bomb.Explode();
                    if (flag)
                    {
                        bomb.time.Stop();
                        Map[bomb.Coordinates].Passable = true;
                        Map[bomb.Coordinates].ContainsBomb = false;
                        tempBomb.Add(bomb);
                        b.Bombs.Remove(bomb);
                        break;
                    }
                }
                ExplodeBomb(tempBomb, temp, b);
                flag = false;
            }

            foreach(BomberMan b in temp)
            {
                BomberMen.Remove(b);
            }
        }

        public string checkGameStat()
        {
            if (BomberMen.Count == 1)
            {
                return string.Format("Bravo {0}", BomberMen[0].Name);
            }
            else if (BomberMen.Count == 0)
            {
                return "Igrata zavrsi remi";
            }
            else
            {
                return "Igrata ne e zavrsena";
            }
        }

        public void Draw(Graphics g)
        {
            foreach (BomberMan b in BomberMen)
            {
                b.Draw(g);
            }
        }

        //if uslovite da se napravat za proverka
        public void ExplodeBomb(List<Bomb> listBomb, List<BomberMan> temp, BomberMan man)
        {
            Point left, right, up, down;
            bool LeftPass, RightPass, UpPass, DownPass;
            DownPass = LeftPass = RightPass = UpPass = true;
            foreach (Bomb bomb in listBomb)
            {
                left = right = up = down = bomb.Coordinates;
                for (int i = 1; i <= bomb.ExplodesionRadius; i++)
                {
                    if (i == 1)
                    {
                        Map[bomb.Coordinates].DestroyBlock();
                        if (Map[bomb.Coordinates].Rectangle.IntersectsWith(man.Frame))
                        {
                            man.Kill();
                            temp.Add(man);
                        }
                    }
                    if (LeftPass)
                    {
                        left = new Point(bomb.Coordinates.X - 50 * i, bomb.Coordinates.Y);
                        if (Map[left].type == Tile.BLOCK_TYPE.Hard)
                        {
                            LeftPass = false;
                        }
                        else
                        {
                            if (Map[left].type == Tile.BLOCK_TYPE.Soft)
                                LeftPass = false;
                            Map[left].DestroyBlock();
                            if (Map[left].Rectangle.IntersectsWith(man.Frame))
                            {
                                man.Kill();
                                temp.Add(man);
                            }
                        }
                    }

                    if (RightPass)
                    {
                        right = new Point(bomb.Coordinates.X + 50 * i, bomb.Coordinates.Y);
                        if (Map[right].type == Tile.BLOCK_TYPE.Hard)
                        {
                            RightPass = false;
                        }
                        else
                        {
                            if (Map[right].type == Tile.BLOCK_TYPE.Soft)
                                RightPass = false;
                            Map[right].DestroyBlock();
                            if (Map[right].Rectangle.IntersectsWith(man.Frame))
                            {
                                man.Kill();
                                temp.Add(man);
                            }
                        }
                    }
                    if (UpPass)
                    {
                        up = new Point(bomb.Coordinates.X, bomb.Coordinates.Y + 50 * i);
                        if (Map[up].type == Tile.BLOCK_TYPE.Hard)
                        {
                            UpPass = false;
                        }
                        else
                        {
                            if (Map[up].type == Tile.BLOCK_TYPE.Soft)
                                UpPass = false;
                            Map[up].DestroyBlock();
                            if (Map[up].Rectangle.IntersectsWith(man.Frame))
                            {
                                man.Kill();
                                temp.Add(man);
                            }
                        }
                    }
                    if (DownPass)
                    {
                        down = new Point(bomb.Coordinates.X, bomb.Coordinates.Y - 50 * i);
                        if (Map[down].type == Tile.BLOCK_TYPE.Hard)
                        {
                            DownPass = false;
                        }
                        else
                        {
                            if (Map[down].type == Tile.BLOCK_TYPE.Soft)
                                DownPass = false;
                            Map[down].DestroyBlock();
                            if (Map[down].Rectangle.IntersectsWith(man.Frame))
                            {
                                man.Kill();
                                temp.Add(man);
                            }
                        }
                    }
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
                            b.Move();
                        
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
