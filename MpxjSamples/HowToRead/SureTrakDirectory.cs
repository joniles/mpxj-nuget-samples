﻿using MPXJ.Net;

namespace MpxjSamples.HowToRead;

public class SureTrakDirectory
{
    public void Read()
    {
        var reader = new UniversalProjectReader();
        var project = reader.Read("my-suretrak-directory");
    }
}
