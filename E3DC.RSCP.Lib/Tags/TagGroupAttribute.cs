namespace E3DC.RSCP.Lib.Tags
{
    [AttributeUsage(AttributeTargets.Enum)]
    public class TagGroupAttribute(uint group) : Attribute
    {
        public uint Group => group;
    }
}
