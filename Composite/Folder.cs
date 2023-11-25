namespace Composite
{
    internal class Folder : Component
    {
        public List<Component> Components { get; set; } = new List<Component>();
        public Folder(string name) : base(name) { }

        public override void View()
        {
            Console.WriteLine($"{Indentation()} Folder : {Name}");
            foreach (var component in Components)
                component.View();
        }

        public Component AddComponent(Component component)
        {
            component.Level = Level+1;
            component.Parent = this;
            Components.Add(component);
            return component;
        }

        public void RemoveComponent(Component component)
            => Components.Remove(component);

        public Component? FindByName(string name)
        {
            foreach (var component in Components)
            {
                if(component.Name.Equals(name))
                    return component;
            }
            return null;
        }
    }
}
