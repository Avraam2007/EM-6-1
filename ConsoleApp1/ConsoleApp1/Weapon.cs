using ConsoleApp1.Name;

namespace ConsoleApp1.Weapon
{
    class Weapon : Name.Name
    {
        protected int damage = 0;
        public Weapon(int damage, string name)
        {
            this.setName(name);
            this.damage = damage;
        }

        public void setDamage(int damage)
        {
            this.damage = damage;
        }

        public int getDamage() => this.damage;

        ~Weapon()
        {

        }
    };
}
