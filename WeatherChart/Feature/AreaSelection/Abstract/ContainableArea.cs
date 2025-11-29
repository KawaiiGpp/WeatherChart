namespace WeatherChart.Feature.AreaSelection.Abstract
{
    public abstract class ContainableArea<ChildType>(string name) : Area(name)
        where ChildType : Area
    {
        private readonly ISet<ChildType> children = new HashSet<ChildType>();

        public IReadOnlyCollection<ChildType> Children => [.. children];

        public void Register(ChildType child)
        {
            if (ConflictsWith(child))
            {
                var name = $"{child.Name} ({child.GetType().Name})";
                throw new ArgumentException($"Element {name} already exists.");
            }
            else
            {
                children.Add(child);
            }
        }

        public ChildType GetOrCreate(string name, Func<string, ChildType> factory)
        {
            var existing = Get(name);

            if (existing != null) return existing;
            var product = factory(name);

            Register(product);
            return product;
        }

        public ChildType GetOrThrow(string name) =>
            Get(name) ?? throw new InvalidOperationException($"Element {name} doesn't exist.");

        public ChildType? Get(string name) => children.FirstOrDefault(element => element.Name == name);

        public bool Matches(string name) => Get(name) != null;

        public bool ConflictsWith(ChildType child) => Matches(child.Name);
    }
}
