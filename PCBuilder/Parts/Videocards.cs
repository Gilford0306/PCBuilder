
namespace PCBuilder.Parts
{
    public class Videocard
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Videocard()
        {
            int key;
            Console.WriteLine("Chose card\n");
            string[] manuf = { "GeForce RTX 3070", "Radeon RX 6750 XT", "GeForce RTX 3050 Dual OC Edition" };
            int[] price = { 27999, 21999, 15209 };
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
            return "Videocard- " + Name;
        }

    }

}
