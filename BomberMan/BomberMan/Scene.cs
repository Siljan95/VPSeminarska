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
        public Map Map { get; set; }

        public Scene()
        {
            BomberMen = new List<BomberMan>();
            Map = new Map();
        }

        public void AddPlayer(BomberMan bomberMan)
        {
            BomberMen.Add(bomberMan);
        }

        public void DrawMap(Graphics g)
        {
            Map.Draw(g);
        }

        public void GenerateMap()
        {
            Map.GenerateMap();
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
                        Map.Tiles[bomb.Coordinates].Passable = true;
                        Map.Tiles[bomb.Coordinates].ContainsBomb = false;
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
                return string.Format("Winer is {0}", BomberMen[0].Name);
            }
            else if (BomberMen.Count == 0)
            {
                return "Draw";
            }
            else
            {
                return "Igrata ne e zavrsena";
            }
        }
        public bool checkGameOver()
        {
            if (BomberMen.Count <= 1)
            {
                return true;
            }
          
            else
            {
                return false;
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
                        Map.Tiles[bomb.Coordinates].DestroyBlock();
                        if (Map.Tiles[bomb.Coordinates].Rectangle.IntersectsWith(man.Frame))
                        {
                            man.Kill();
                            temp.Add(man);
                        }
                    }
                    if (LeftPass)
                    {
                        left = new Point(bomb.Coordinates.X - 50 * i, bomb.Coordinates.Y);
                        if (Map.Tiles[left].type == Tile.BLOCK_TYPE.Hard)
                        {
                            LeftPass = false;
                        }
                        else
                        {
                            if (Map.Tiles[left].type == Tile.BLOCK_TYPE.Soft)
                                LeftPass = false;
                            Map.DestroyBlock(left);
                            if (Map.Tiles[left].Rectangle.IntersectsWith(man.Frame))
                            {
                                man.Kill();
                                temp.Add(man);
                            }
                        }
                    }

                    if (RightPass)
                    {
                        right = new Point(bomb.Coordinates.X + 50 * i, bomb.Coordinates.Y);
                        if (Map.Tiles[right].type == Tile.BLOCK_TYPE.Hard)
                        {
                            RightPass = false;
                        }
                        else
                        {
                            if (Map.Tiles[right].type == Tile.BLOCK_TYPE.Soft)
                                RightPass = false;
                            Map.Tiles[right].DestroyBlock();
                            if (Map.Tiles[right].Rectangle.IntersectsWith(man.Frame))
                            {
                                man.Kill();
                                temp.Add(man);
                            }
                        }
                    }
                    if (UpPass)
                    {
                        up = new Point(bomb.Coordinates.X, bomb.Coordinates.Y + 50 * i);
                        if (Map.Tiles[up].type == Tile.BLOCK_TYPE.Hard)
                        {
                            UpPass = false;
                        }
                        else
                        {
                            if (Map.Tiles[up].type == Tile.BLOCK_TYPE.Soft)
                                UpPass = false;
                            Map.Tiles[up].DestroyBlock();
                            if (Map.Tiles[up].Rectangle.IntersectsWith(man.Frame))
                            {
                                man.Kill();
                                temp.Add(man);
                            }
                        }
                    }
                    if (DownPass)
                    {
                        down = new Point(bomb.Coordinates.X, bomb.Coordinates.Y - 50 * i);
                        if (Map.Tiles[down].type == Tile.BLOCK_TYPE.Hard)
                        {
                            DownPass = false;
                        }
                        else
                        {
                            if (Map.Tiles[down].type == Tile.BLOCK_TYPE.Soft)
                                DownPass = false;
                            Map.Tiles[down].DestroyBlock();
                            if (Map.Tiles[down].Rectangle.IntersectsWith(man.Frame))
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
                        if (b.canPass(Map.Tiles))
                            b.Move();
                        
                    }
                    if (k == b.CommandDown)
                    {
                        b.ChangeDirection(BomberMan.DIRECTION.DOWN);
                        if (b.canPass(Map.Tiles))
                            b.Move();
                    }
                    if (k == b.CommandRight)
                    {
                        b.ChangeDirection(BomberMan.DIRECTION.RIGHT);
                        if (b.canPass(Map.Tiles))
                            b.Move();
                    }
                    if (k == b.CommandLeft)
                    {
                        b.ChangeDirection(BomberMan.DIRECTION.LEFT);
                        if (b.canPass(Map.Tiles))
                            b.Move();
                    }
                    if (k == b.CommandPutBomb)
                    {
                        b.PlaceBomb(Map.Tiles);
                    }
                }
            }
        }
    }
}
