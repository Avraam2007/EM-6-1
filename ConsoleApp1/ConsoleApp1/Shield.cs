using ConsoleApp1.Name;

namespace ConsoleApp1.Shield
{
    class Shield : Name.Name
    {
        protected int protect = 0;
        public Shield(int protect, string name)
        {
            this.protect = protect;
            this.setName(name);
        }
        public void setProtect(int protect)
        {
            this.protect = protect;
        }

        public int getProtect() => this.protect;


        ~Shield()
        {

        }
    };
}


