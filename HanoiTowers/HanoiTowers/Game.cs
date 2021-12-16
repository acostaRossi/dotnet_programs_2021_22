using System;

namespace HanoiTowers
{
    public class Game {

        private int _disks;

        private Tower[] towers;

        private int _steps = 0;

        public int Steps { get => _steps; }

        public Game(int diskNumber)
        {
            _disks = diskNumber;

            towers = new Tower[] {
                new Tower("b"),
                new Tower("i"),
                new Tower("d")
            };

            for (int i = diskNumber; i > 0; i--)
            {
                towers[0].Push(i);
            }
        }
        void Move(string tower1, string tower2)
        {
            Tower towerOrigin = null;
            Tower towerDestination = null;

            for (int i = 0; i < towers.Length; i++)
            {
                if (towers[i].name == tower1)
                {
                    towerOrigin = towers[i];
                }

                if (towers[i].name == tower2)
                {
                    towerDestination = towers[i];
                }
            }

            if (towerDestination.IsEmpty())
            {
                towerDestination.Push(towerOrigin.Pop());
            }
            else if (towerOrigin.IsEmpty())
            {
                towerOrigin.Push(towerDestination.Pop());
            }
            else if (towerDestination.Peek() > towerOrigin.Peek())
            {
                towerDestination.Push(towerOrigin.Pop());
            }
            else if (towerOrigin.Peek() > towerDestination.Peek())
            {
                towerOrigin.Push(towerDestination.Pop());
            }

            _steps++;

            Console.WriteLine(this.ToString() + "\n");
        }
        public void Resolve()
        {
            while (!IsResolved())
            {
                // even
                if (_disks % 2 == 0)
                {
                    if (!IsResolved()) Move("b", "i");
                    if (!IsResolved()) Move("b", "d");
                    if (!IsResolved()) Move("i", "d");
                }
                // odd
                else
                {
                    if (!IsResolved()) Move("b", "d");
                    if (!IsResolved()) Move("b", "i");
                    if (!IsResolved()) Move("i", "d");
                }
            }
        }
        bool IsResolved()
        {

            if (towers[2].Counter == _disks)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            string s = "";

            foreach (Tower tower in towers)
            {

                s += tower.ToString();
                s += "\n";
            }

            s += "\n";
            s += $"Steps: { Steps }";

            return s;
        }
    }
}
