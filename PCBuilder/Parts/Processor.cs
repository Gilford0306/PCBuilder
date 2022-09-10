
namespace PCBuilder.Parts
{
    public class Processor
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Processor()
        {
            int key;
            Console.WriteLine("Chose processor\n");
            string[] manuf = { "AMD Ryzen 5 5600G", "Intel Core i9-12900K", "Intel Pentium Gold G6405" };
            int[] price = { 7039, 28365, 2399 };
            for (int i = 0; i < manuf.Length; i++)
            {
                Console.WriteLine($"{i + 1}. - {manuf[i]} ");
            }
            do
            {
                key = int.Parse(Console.ReadLine());
                key--;
                if (key > -1 && key < manuf.Length)
                {
                    this.Name = manuf[key];
                    this.Price = price[key];
                    break;
                }
                Console.WriteLine("Erorre - Input againe");
            } while (true);
        }

        public override string ToString()
        {
            return "Processor - " + Name;
        }

    }

}
