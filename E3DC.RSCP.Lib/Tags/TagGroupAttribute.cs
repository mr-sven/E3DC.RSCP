namespace E3DC.RSCP.Lib.Tags
{
    [AttributeUsage(AttributeTargets.Enum)]
    public class TagGroupAttribute : Attribute
    {
        public uint Group { get; }
        public TagGroupAttribute(uint Group)
        {
            this.Group = Group;
        }
    }
}
