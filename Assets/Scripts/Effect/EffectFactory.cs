using UnityEngine;

public class EffectFactory
{
    public static Effect GetEffect(EffectEnum nameEnum, GameObject tank, EffectObject effectObject)
    {
        switch (nameEnum)
        {
            case EffectEnum.Boots:
                return new BootsEffect(tank, effectObject);
            case EffectEnum.Slow:
                return new SlowEffect(tank, effectObject);
            default:
                Debug.LogError("Effect name incorrect @@ !");
                return null;
        }
    }
}
