﻿using System;

public class QuickAndDirtyGreeterService()
{
    DateTime now = DateTime.Now;

    public QuickAndDirtyGreeterService(DateTime referenceNow) : this()
    {
        now = referenceNow;
    }

    public string Greet()
    {
        return now.Hour switch
        {
            >= 5 and < 12 => "God morgon!",
            >= 12 and < 18 => "God eftermiddag!",
            _ => "God kväll!"
        } + $" Klockan är {now.ToLongTimeString()}";
    }
}