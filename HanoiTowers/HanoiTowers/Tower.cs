namespace HanoiTowers
{
    public class Tower: Stack {

        public string name;
        public Tower(string name, int towerSize = 20) : base(towerSize)
        {
            this.name = name;
        }
        public override string ToString()
        {

            string s = "Tower " + this.name + ":\t";

            s += base.ToString();

            return s;
        }

    }
}
