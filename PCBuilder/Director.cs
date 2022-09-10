using PCBuilder.Builders;

namespace PCBuilder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }
        public void BuildMinimalPC()
        {
            this._builder.AddMotherboard();
            this._builder.AddProcessor();
            this._builder.AddRam();
            this._builder.AddHDD();
        }
        public void BuildGamerPC()
        {
            this._builder.AddMotherboard();
            this._builder.AddProcessor();
            this._builder.AddRam();
            this._builder.AddHDD();
            this._builder.AddVideocard();
        }
    }
}
