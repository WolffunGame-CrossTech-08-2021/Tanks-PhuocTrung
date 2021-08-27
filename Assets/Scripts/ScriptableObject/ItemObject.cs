using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class ItemObject : ScriptableObject
{
    public new string name;
    public ItemEnum nameEnum;
    public ItemType type;
    public Mesh mesh;
    public Color color = Color.white;
    public float scale = 1.0f;
    // public Effect[] effects;

    public void ActiveItem(GameObject tank)
    {
        ItemFactory.GetItem(nameEnum).ActiveItem(tank);
    }
}
