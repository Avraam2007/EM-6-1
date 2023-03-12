using ConsoleApp1.Name;

namespace ConsoleApp1.BasePerson
{
    class BasePerson : Name.Name
    {
        protected int health = 0;
        protected int healthMax = 0;
        protected int energy = 0;
        protected int level = 0;

        public BasePerson(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        public void showInfo()
        {
            Console.WriteLine($"{this.name} {this.level} lvl.");

            Console.Write("\t[");
            double tmp = ((double)this.health / (double)this.healthMax) * 10;
            for (int i = 0; i < 10; i++)
            {
                if (i < tmp)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("♥");
                    Console.ResetColor();
                }
                else
                    Console.Write("♥");
            }
            Console.Write("]");
            Console.WriteLine($"\n\t {this.health} / {this.healthMax}");
        }

        public void setHealth(int health)
        { this.health = health; }

        public void setEnergy(int energy)
        { this.energy = energy; }

        public void setLevel(int level)
        { this.level = level; }

        public int getHealth() => this.health;

        public void addHealth(int value)
        {
            if (value + this.health > this.healthMax)
                this.health = this.healthMax;
            else
                this.health += value;
        }

        public int getEnergy() => this.energy;

        public int getLevel() => this.level;
    }
}

