using System;
using System.Collections.Generic;
using System.Linq;

namespace RimTrans.Builder.Crawler
{
    public static class TypeExtensions
    {
        public static IEnumerable<Type> AllSubclasses(this Type type)
        {
            return TypeLoader.LoadAll().Where(x => x.IsSubclassOf(type)).ToList();
        }
    }
}
