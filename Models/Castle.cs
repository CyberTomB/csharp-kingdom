using System;

namespace csharp_kingdom.Models
{
    public class Castle
    {
        public string Id {get; set;} = Guid.NewGuid().ToString();
        public string Name {get; set;}
    }
}