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
        if (!_itemObject) return;
        TankEffect tankEffect = tank.GetComponent<TankEffect>();
        foreach (var effect in _itemObject.effects)
        {
            Effect currentEffect = effect.EffectObjectLogic.GetCurrentEffect(tank);
            tankEffect.AddEffect(currentEffect);
            currentEffect.ActiveEffect();
        }
    }
}
