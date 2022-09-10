namespace PCBuilder.Builders
{
    public interface IBuilder
    {
        void AddMotherboard();

        void AddProcessor();

        void AddRam();

        void AddHDD();

        void AddVideocard();
    }
}
