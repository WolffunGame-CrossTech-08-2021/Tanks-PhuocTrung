using UnityEngine;

public abstract class Item
{
    protected ItemObject _itemObject;

    public Item SetItemObject(ItemObject item)
    {
        _itemObject = item;
        return this;
    }

    public virtual void ActiveItem(GameObject tank)
    {
        if (_itemObject)
        {
            for (int i = 0; i < _itemObject.effects.Length; i++)
            {
                
            }
        }
    }
}
