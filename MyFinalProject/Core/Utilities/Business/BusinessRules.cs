﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business;

public class BusinessRules
{
    public static IResult Run(params IResult[] logics) //params yerine list de yazılabilir
    {
        foreach (var logic in logics)
        {
            if(!logic.Success)
            {
                return logic;
            }
        }
        return null;
    }
}
