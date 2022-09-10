using PCBuilder.Parts;
using PCBuilder.Products;

namespace PCBuilder.Builders
{

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public int totalprice { get; set; } = 0;

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void AddMotherboard()
        {
            MotherBoard mb = new MotherBoard();
            this._product.Add(mb.ToString(),mb.Price);
        }

        public void AddProcessor()
        {
            Processor pr = new Processor();
            this._product.Add(pr.ToString(), pr.Price);
        }

        public void AddRam()
        {
            RAM ram = new RAM();
            this._product.Add(ram.ToString(), ram.Price);
        }

        public void AddHDD()
        {
            HDD hdd = new HDD();
            this._product.Add(hdd.ToString(), hdd.Price);
        }

        public void AddVideocard()
        {
            Videocard vc = new Videocard();
            this._product.Add(vc.ToString(), vc.Price);
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }

}
