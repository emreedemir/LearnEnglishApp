using System;
using System.Collections.Generic;

[Serializable]
public class Pack 
{
    public int id;
    public string packName;
    public string packDescription;
    public List<Unit> units;
}
