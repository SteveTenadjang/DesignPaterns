namespace Composite
{
    internal abstract class Component
    {
        public string Name { get; protected set; }
        public int Level { get; set; }
        public Folder? Parent { get; set; }

        public Component(string name)
        {
            Name = name;
        }
        public abstract void View();

        public string Indentation()
        {
            string indent = "";
            for (int i = 0; i < Level; i++)
                indent+= "\t";
            return indent;
        }
    }
}
