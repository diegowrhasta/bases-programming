using DummyLibrary.Extensions;

namespace DummyLibrary;

public class TreeFactory
{
    public IList<TreeType> TreeTypes { get; set; } = new List<TreeType>();

    public TreeType GetTreeType(string name, string color, string texture)
    {
        var cachedTreeType = TreeTypes
            .FirstOrDefault(t =>
                t.Name.SameAs(name) &&
                t.Color.SameAs(color) &&
                t.Texture.SameAs(texture));

        if (cachedTreeType is not null)
        {
            return cachedTreeType;
        }

        cachedTreeType = new TreeType
        {
            Name = name,
            Color = color,
            Texture = texture,
        };
        TreeTypes.Add(cachedTreeType);

        return cachedTreeType;
    }
}