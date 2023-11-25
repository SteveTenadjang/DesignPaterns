namespace Composite
{
    internal class File : Component
    {
        public File(string name) : base(name) {}

        public override void View()
            => Console.WriteLine($"{Indentation()} |- {Name}");
    }
}
