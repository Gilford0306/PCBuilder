
namespace PCBuilder.Parts
{
    public class HDD
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public HDD()
        {
            int key;
            Console.WriteLine("Chose SDD\n");
            string[] manuf = { "Kingston SSDNow A400 240GB", "Western Digital Black SN770 NVMe ", "Samsung 970 Evo Plus 1TB" };
            int[] price = { 1149, 4999, 5999 };
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
            return "SDD- " + Name;
        }

    }

}
