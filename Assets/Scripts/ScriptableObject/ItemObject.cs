using UnityEngine;

[CreateAssetMenu(menuName = "Tanks/Item")]
public class ItemObject : ScriptableObject
{
    public new string name;
    public ItemEnum nameEnum;
    public ItemType type;
    public Mesh mesh;
    public Color color = Color.white;
    public float scale = 1.0f;
    public EffectObject[] effects;

    public void ActiveItem(GameObject tank)
    {
        ItemFactory.GetItem(nameEnum)
            .SetItemObject(this)
            .ActiveItem(tank);
    }
}
