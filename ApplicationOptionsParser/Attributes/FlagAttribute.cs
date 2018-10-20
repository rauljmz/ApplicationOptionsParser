using System;

namespace ApplicationOptionsParser.Attributes
{
    public class FlagAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
