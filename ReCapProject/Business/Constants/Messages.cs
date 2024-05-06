﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants;

public class Messages
{
    public static string CarAdded = "Araba eklendi";
    public static string CarNameInvalid = "Araba ismi geçersiz";
    public static string MaintenanceTime = "Sistem bakımda";
    public static string CarListed = "Arabalar listelendi";
    public static string CarDeleted;
    public static string Error;
    public static string CarUpdated;
    public static string ReturnDateNull;


    public static string CarInvalid { get; internal set; }
}
