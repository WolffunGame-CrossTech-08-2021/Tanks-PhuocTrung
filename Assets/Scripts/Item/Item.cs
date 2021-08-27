using UnityEngine;

public abstract class Item
{
    protected ItemObject _itemObject;

    public abstract void ActiveItem(GameObject tank);
}