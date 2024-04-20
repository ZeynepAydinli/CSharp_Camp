using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results;

public class Result : IResult
{
    public Result(bool success, string message) : this (success)
    {
        Message = message;
        //Success = success;
    }
    public Result(bool success)
    {
        Success = success;
    }

    //Sadece get yazıldığı için return yapılması gerektiğini biliyor => işaretinden sonra
    //yazılanlar otomatik olarak return olarak algılanılır.

    public bool Success { get; } 

    public string Message { get; }
}
