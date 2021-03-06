﻿using RandomicGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConnect
{
    public static class Utils
    {
        private static Dictionary<string, IRandomGenerator> generators = new Dictionary<string, IRandomGenerator>();

        public static IEnumerable<IRandomGenerator> Generators => generators.Values;

        public static IRandomGenerator Get(string name)
        {
            if (generators.TryGetValue(name, out IRandomGenerator result))
                return result;
            return null;
        }

        public static void Register(IRandomGenerator generator)
        {
            generators[generator.Name] = generator;
        }
    }
}
