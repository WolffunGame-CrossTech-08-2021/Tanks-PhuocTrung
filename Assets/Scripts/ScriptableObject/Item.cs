using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    public int id;
    public new string name;
    public Mesh mesh;
    public Effect[] effects;
}
