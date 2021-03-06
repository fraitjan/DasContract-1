﻿using Liquid.NET.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace DasToSolidity.SolidityConverter
{

    public class SolidityParameter
    {
        string dataType;
        string name;

        public SolidityParameter(string dataType, string name)
        {
            this.dataType = dataType;
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public LiquidString ToLiquidString()
        {
            if (dataType == "string")
                return LiquidString.Create(dataType + " memory " + name);
            return LiquidString.Create(dataType + " " + name);
        }
    }
}
