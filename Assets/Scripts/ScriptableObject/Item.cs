using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Enhance, // Giày, bình máu, ...
    Battle // Tên lửa, bình độc
}

[CreateAssetMenu(menuName = "Items")]
public class Item : ScriptableObject
{
    public new string name;
    public ItemType type;
    public Mesh mesh;
    public Color color = Color.white;
    public float scale = 1.0f;
    public Effect[] effects;
}
