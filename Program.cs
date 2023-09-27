using System;
class Processor
{
    public string merk;
    public string tipe;
    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }

    class Intel : Processor
    {
        public string merk = "Intel";
        public Intel(string merk, string tipe) : base(merk, tipe)
        {
            this.merk = merk;
        }
    }
    class CoreI3 : Intel
    {
        public string tipe = "Core i3";
        public CoreI3(string merk, string tipe) : base(merk, tipe)
        {
            this.tipe = tipe;
        }
    }
    class CoreI5 : Intel
    {
        public string tipe = "Core i5";
        public CoreI5(string merk, string tipe) : base(merk, tipe)
        {
            this.tipe = tipe;
        }
    }
    class CoreI7 : Intel
    {
        public string tipe = "Core i7";
        public CoreI7(string merk, string tipe) : base(merk, tipe)
        {
            this.tipe = tipe;
        }
    }
    class AMD : Processor
    {
        public string merk = "AMD";
        public AMD(string merk, string tipe) : base(merk, tipe)
        {
            this.merk = merk;
        }
    }
    class Ryzen : AMD
    {
        public string tipe = "RAYZEN";
        public Ryzen(string merk, string tipe) : base(merk, tipe)
        {
            this.tipe = tipe;
        }
    }
    class Athion : AMD
    {
        public string tipe = "ATHLON";
        public Athion(string merk, string tipe) : base(merk, tipe)
        {
            this.tipe = tipe;
        }
    }
    class Vga
    {
        public string merk;
        public Vga(string merk)
        {
            this.merk = merk;
        }
    }
    class Nvidia : Vga
    {
        public string merk = "Nvidia";
        public Nvidia(string merk) : base(merk)
        {
            this.merk = merk;
        }
    }
    class amd : Vga
    {
        public string merk = "AMD";
        public amd(string merk) : base(merk)
        {
            this.merk = merk;
        }
    }
    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;
        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
        }
    }
    class ASUS : Laptop
    {
        public string merk = "ASUS";
        public ASUS(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.merk = merk;
        }
    }
    class ROG : ASUS
    {
        public string tipe = "ROG";
        public ROG(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.tipe = tipe;
        }
    }
    class Vivobook : ASUS
    {
        public string tipe = "Vivobook";
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi");
        }
        public Vivobook(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.tipe = tipe;
        }
    }
    class ACER : Laptop
    {
        public string merk = "Acer";
        public ACER(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.merk = merk;
        }
    }
    class Swift : ACER
    {
        public string tipe = "Swift";
        public Swift(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.tipe = tipe;
        }
    }
    class Predator : ACER
    {
        public string tipe = "Predator";
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
        }
        public Predator(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.tipe = tipe;
        }
    }
    class Lenovo : Laptop
    {
        public string merk = "Lenovo";
        public Lenovo(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.merk = merk;
        }
    }
    class IdeaPad : Lenovo
    {
        public string tipe = "IdeaPad";
        public IdeaPad(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.tipe = tipe;
        }
    }
    class Legion : Lenovo
    {
        public string tipe = "Legion";
        public Legion(string merk, string tipe, Vga vga, Processor processor) : base(merk, tipe, vga, processor)
        {
            this.tipe = tipe;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vga nvidia = new Vga("Nvidia");
            CoreI5 corei5 = new CoreI5("Intel", "Core i5");
            Laptop laptop1 = new Vivobook("ASUS", "Vivobook", nvidia, corei5);
            //soalno.2
            //laptop1.Ngoding();
            //((Vivobook)laptop1).Ngoding();

            //soalno.3
            //Console.WriteLine($"Spesifikasi laptop 1 : merk {laptop1.merk}, tipe {laptop1.tipe}, VGA {laptop1.vga.merk} dan processor {laptop1.processor.tipe}");


            AMD ryzen = new AMD("AMD", "Ryzen");
            Vga AMD = new Vga("AMD");
            Laptop laptop2 = new IdeaPad("Lenovo", "IdeaPad", AMD, ryzen);
            //soalno.1
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();

            CoreI7 corei7 = new CoreI7("Intel", "Core i7");
            Laptop predator = new Predator("ACER", "Predator", AMD, corei7);
            //soalno.4
            //predator.BermainGame();
            //((Predator)predator).BermainGame();

            ACER acer = new Predator("ACER", "Predator", AMD, corei7);
            //soalno.5
            //acer.BermainGame();
        }
    }
}