
namespace PCBuilder.Parts
{
    public class RAM
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public RAM()
        {
            int key;
            Console.WriteLine("Chose RAM\n");
            string[] manuf = { "Kingston Fury DDR5-6000 32768MB", "Kingston Fury DDR4-3200 8192MB", "Goodram DDR4-3200 8192MB " };
            int[] price = { 10699, 1199, 1072 };
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
            return "RAM- " + Name;
        }

    }

}
