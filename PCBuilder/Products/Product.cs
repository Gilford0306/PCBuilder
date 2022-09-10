

namespace PCBuilder.Products
{

    public class Product
    {
        private List<object> _parts = new List<object>();
        public int TotalPrice = 0;


        public void Add(string part, int price)
        {
            this._parts.Add(part);
            TotalPrice += price;
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + "\n";
            }

            str = str.Remove(str.Length - 2); 

            return "Product parts:\n" + str + "\n" + "Total Price - " + TotalPrice + " Uah";
        }
    }

}
