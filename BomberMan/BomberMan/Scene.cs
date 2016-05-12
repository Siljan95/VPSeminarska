using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BomberMan
{
    class Scene
    {
        /// <summary>
        /// List of players
        /// </summary>
        public List<BomberMan> BomberMen;

        public Timer destroyMapTimer;
        int i;
        int j;
        /// <summary>
        /// Controler for the map
        /// </summary>
        public Map Map { get; set; }

        /// <summary>
        /// Constructor for the Scene. It Initilize the List and the Map
        /// </summary>
        public Scene()
        {
            BomberMen = new List<BomberMan>();
            Map = new Map();
            destroyMapTimer = new Timer();
            destroyMapTimer.Interval = 400;
            destroyMapTimer.Tick += new EventHandler(DestroyMap);
            i = 1;
            j = 1;
        }

        /// <summary>
        /// Adds the player to the Scene
        /// </summary>
        public void AddPlayer(BomberMan bomberMan)
        {
            BomberMen.Add(bomberMan);
        }

        /// <summary>
        /// Draws the Map
        /// </summary>
        /// <param name="g"></param>
        public void DrawMap(Graphics g)
        {
            Map.Draw(g);
        }

        /// <summary>
        /// Generates the map when a new game is started
        /// </summary>
        public void GenerateMap()
        {
            Map.GenerateMap();
        }

        /// <summary>
        /// Counts down the timer in the bomb
        /// </summary>
        public void Count()
        {
            bool flag = false;
            List<BomberMan> temp = new List<BomberMan>();
            foreach (KeyValuePair<Point, Bomb> bomb in Map.placedBombs)
            {
                bomb.Value.CountDown -= 1;
                flag = bomb.Value.Explode();
                if (flag)
                {
                    bomb.Value.time.Stop();
                    ExplodeBomb(bomb.Value, Map.Tiles[bomb.Value.Coordinates].WhoPlaced);
                    Map.placedBombs.Remove(bomb.Key);
                    break;
                }
            }
            flag = false;

            foreach (BomberMan b in BomberMen)
            {
                if (!b.IsAlive)
                    temp.Add(b);
            }
            foreach (BomberMan b in temp)
            {
                BomberMen.Remove(b);
            }
        }

        private bool explode(Point direction, BomberMan man)
        {
            bool flag = true;
            if (Map.Tiles[direction].type == Tile.BLOCK_TYPE.Hard)
            {
                flag = false;
            }
            else
            {
                if (Map.Tiles[direction].type == Tile.BLOCK_TYPE.Soft)
                {
                    man.IncreaseScore(50);
                    flag = false;
                }
                man.IncreaseScore(man.Kill(BomberMen, Map.Tiles[direction]));
                if (Map.Tiles[direction].ContainsBomb)
                {
                    ExplodeBomb(Map.Tiles[direction].WhoPlaced.Bombs[direction], Map.Tiles[direction].WhoPlaced);
                    Map.Tiles[direction].WhoPlaced.Bombs.Remove(direction);
                    Map.placedBombs.Remove(direction);
                }
                Map.DestroyBlock(direction, Map.Tiles[direction].type);
            }
            return flag;
        }

        /// <summary>
        /// Explodes the bomb
        /// </summary>
        public void ExplodeBomb(Bomb bomb, BomberMan man)
        {
            Point left, right, up, down;
            bool LeftPass, RightPass, UpPass, DownPass;

            DownPass = LeftPass = RightPass = UpPass = true;
            left = right = up = down = bomb.Coordinates;
            for (int i = 1; i <= bomb.ExplodesionRadius; i++)
            {
                if (i == 1)
                {
                    Map.Tiles[bomb.Coordinates].DestroyBlock();
                    man.Kill(BomberMen, Map.Tiles[bomb.Coordinates]);
                    Map.Tiles[left].WhoPlaced.Bombs.Remove(bomb.Coordinates);
                    Map.placedBombs.Remove(bomb.Coordinates);
                }
                if (LeftPass)
                {
                    left = new Point(bomb.Coordinates.X - 50 * i, bomb.Coordinates.Y);
                    LeftPass = explode(left, man);
                }

                if (RightPass)
                {
                    right = new Point(bomb.Coordinates.X + 50 * i, bomb.Coordinates.Y);
                    RightPass = explode(right, man);

                }
                if (UpPass)
                {
                    up = new Point(bomb.Coordinates.X, bomb.Coordinates.Y + 50 * i);
                    UpPass = explode(up, man);
                }
                if (DownPass)
                {
                    down = new Point(bomb.Coordinates.X, bomb.Coordinates.Y - 50 * i);
                    DownPass = explode(down, man);
                }
            }
        }

        /// <summary>
        /// Takes the item and powersUp the player that took the item
        /// </summary>
        /// <param name="b">Player that took the item</param>
        public void takeItem(BomberMan b)
        {
            List<Item> temp = new List<Item>();
            foreach (Item i in Map.Items)
            {
                if (b.Frame.IntersectsWith(i.getLocation()))
                {
                    b.IncreaseScore(100);
                    i.PowerUp(b);
                    temp.Add(i);
                }
            }
            foreach (Item i in temp)
            {
                Map.Items.Remove(i);
            }
        }

        /// <summary>
        /// Moves the player in the chosen direction
        /// </summary>
        /// <param name="keys">List of commands that the players have inputed</param>
        public void MovePlayer(List<Keys> keys)
        {
            foreach (BomberMan b in BomberMen)
            {
                foreach (Keys k in keys)
                {
                    if (k == b.CommandUp)
                    {
                        b.ChangeDirection(BomberMan.DIRECTION.UP);
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
                        b.PlaceBomb(Map);
                    }
                }
                takeItem(b);
            }
        }

        //treba da se napravi da ne vraka strings
        /// <summary>
        /// Checks the status of the game
        /// </summary>
        /// <returns></returns>
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
            return "";
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

        public void DestroyMap(object sender, EventArgs e)
        {
            Point destroy = new Point(i * 50, j * 50);
            Map.Tiles[destroy].CreateHardBlock();
            foreach(BomberMan b in BomberMen)
            {
                if (Map.Tiles[destroy].Rectangle.IntersectsWith(b.Frame)) {
                    Debug.WriteLine("DAA");
                    b.IsAlive = false;
                    Debug.WriteLine(b.IsAlive.ToString());
                }
            }

            if (i <= 9)
                i++;
            else {
                i = 1;
                if (j <= 10)
                    j++;
            }
        }

        /// <summary>
        /// Draws the bomberman
        /// </summary>
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
