﻿using System;
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
        public List<Bomb> tempBombs{ get; set; }

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
            List<Bomb> tempBombs = new List<Bomb>();
            foreach (BomberMan b in BomberMen)
            {
                foreach (KeyValuePair<Point, Bomb> bomb in b.Bombs)
                {
                    bomb.Value.CountDown -= 1;
                    flag = bomb.Value.Explode();
                    if (flag)
                    {
                        bomb.Value.time.Stop();
                        Map.Tiles[bomb.Value.Coordinates].Passable = true;
                        Map.Tiles[bomb.Value.Coordinates].ContainsBomb = false;
                        ExplodeBomb(bomb.Value, temp, b);
                        b.Bombs.Remove(bomb.Key);
                        break;
                    }
                }
                //Treba da se napravi koga edna bomba kje se unisti da se unisti i druga
                //foreach (Bomb bomb in tempBombs)
                //{
                //    ExplodeBomb(bomb, temp, b);
                //    b.Bombs.Remove(bomb.Coordinates);
                //}
                //flag = false;
            }

            foreach (BomberMan b in temp)
            {
                BomberMen.Remove(b);
            }
        }

        //if uslovite da se napravat za proverka
        public void ExplodeBomb(Bomb bomb, List<BomberMan> temp, BomberMan man)
        {
            Point left, right, up, down;
            bool LeftPass, RightPass, UpPass, DownPass;

            DownPass = LeftPass = RightPass = UpPass = true;
            left = right = up = down = bomb.Coordinates;
            for (int i = 1; i <= bomb.ExplodesionRadius; i++)
            {
                Map.DestroyItem(left, right, up, down);
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
                        Map.DestroyBlock(left, Map.Tiles[left].type);
                        if (Map.Tiles[left].ContainsBomb)
                            tempBombs.Add(man.Bombs[left]);
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
                        {
                            RightPass = false;
                        }
                        Map.DestroyBlock(right, Map.Tiles[right].type);
                        if (Map.Tiles[right].ContainsBomb)
                            tempBombs.Add(bomb);
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
                        {
                            UpPass = false;
                        }
                        Map.DestroyBlock(up, Map.Tiles[up].type);
                        if (Map.Tiles[up].ContainsBomb)
                            tempBombs.Add(bomb);
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
                        {
                            DownPass = false;
                        }
                        Map.DestroyBlock(down, Map.Tiles[down].type);
                        if (Map.Tiles[down].ContainsBomb)
                            tempBombs.Add(bomb);
                        if (Map.Tiles[down].Rectangle.IntersectsWith(man.Frame))
                        {
                            man.Kill();
                            temp.Add(man);
                        }
                    }
                }
            }
        }

        public void takeItem(BomberMan b)
        {
            List<Item> temp = new List<Item>();
            foreach (Item i in Map.Items)
            {
                if (b.Frame.IntersectsWith(i.getLocation()))
                {
                    i.PowerUp(b);
                    temp.Add(i);
                }
            }
            foreach (Item i in temp)
            {
                Map.Items.Remove(i);
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
                        {
                            b.Move();
                        }
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
                takeItem(b);
            }
        }

        //treba da se napravi da ne vraka strings
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
            Map.DrawItems(g);
        }
    }
}
