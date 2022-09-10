
namespace PCBuilder.Parts
{
    public class MotherBoard
    {
        public string Name { get; set; }
        public int Price  { get; set; }

        public MotherBoard()
        {
            int key;
            Console.WriteLine("Chose card\n");
            string[] manuf = { "Asus Prime H510M", "Gigabyte Z590", "ASRock A320M" };
            int[] price = { 2688, 42999, 1462 };
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
            return "Motherboard- " + Name;
        }

    }
    
}
