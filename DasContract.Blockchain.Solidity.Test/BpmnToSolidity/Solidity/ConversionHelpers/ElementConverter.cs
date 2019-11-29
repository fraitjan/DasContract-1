﻿using BpmnToSolidity.SolidityConverter;
using System;
using System.Collections.Generic;
using System.Text;

namespace BpmnToSolidity.Solidity.ConversionHelpers
{
    public abstract class ElementConverter
    {
        public abstract IList<SolidityComponent> GetElementCode(List<ElementConverter> nextElements);
        public abstract SolidityStatement GetStatementForPrevious();
    }
}
