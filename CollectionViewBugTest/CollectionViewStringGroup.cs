namespace CollectionViewBugTest;

public class CollectionViewStringGroup : List<string>
{
    public string GroupHeader { get; private set; }
    public CollectionViewStringGroup(string header, IEnumerable<string> data) : base(data)
    {
        GroupHeader = header;
    }
}
