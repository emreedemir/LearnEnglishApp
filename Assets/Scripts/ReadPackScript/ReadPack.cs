using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ReadPack
{
    public int id;
    public string description;
    public int wordCount;
    public List<Unit> readUnit;
}
