using Ducks.Ducks;
using Ducks.Enums;
using System.Collections.Generic;

namespace Ducks.Mapper
{
    public class DuckMapper
    {
        public List<KeyValuePair<DucksEnum, Duck>> duckDictionary = new List<KeyValuePair<DucksEnum, Duck>>();

        public DuckMapper()
        {
            duckDictionary.Add(new KeyValuePair<DucksEnum, Duck>(DucksEnum.MallardDuck, new MallardDuck()));
            duckDictionary.Add(new KeyValuePair<DucksEnum, Duck>(DucksEnum.RedheadDuck, new RedheadDuck())); 
            duckDictionary.Add(new KeyValuePair<DucksEnum, Duck>(DucksEnum.RubberDuck, new RubberDuck()));
            duckDictionary.Add(new KeyValuePair<DucksEnum, Duck>(DucksEnum.DecoyDuck, new DecoyDuck()));
        }
    }
}
