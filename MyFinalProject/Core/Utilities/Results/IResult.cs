﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results;

//Temel voidler için başlangıç

public interface IResult
{
    bool Success { get; } //Sadece get kullanılır
    string Message { get; }
}
