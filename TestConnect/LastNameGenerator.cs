
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TestConnect;

namespace RandomicGenerator
{
    [Serializable]
    class LastNameGenerator : IRandomGenerator
    {
        private Random r = new Random(DateTime.Now.Millisecond);
        private string[] syllable = { "ma", "lee", "cru", "ste", "ve", "la", "le", "si", "va", "mo", "mi", "lo", "su", "sa", "no", "ge", "tri", "co" };
        private string lastName;

        public string Name => "Last name";

        public string ColumnName { get; set; }

        public Type Type => typeof(string);

        public IRandomGenerator Create()
        {
            return new LastNameGenerator();
        }

        public object Next()
        {
            lastName = "";
            for (int i = 0; i < r.Next(5) + 2; i++)
            {
                lastName += syllable[r.Next(syllable.Length)];
            }
            //Преобразует первый символ получившейся строки в верхний регистр 
            lastName = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lastName);

            return lastName;
        }
    }
}