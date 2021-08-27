using UnityEngine;

public class EffectFactory
{
    public static Effect GetEffect(EffectEnum nameEnum, GameObject tank, EffectObject effectObject, EffectFor effectFor, float duration)
    {
        switch (nameEnum)
        {
            case EffectEnum.Boots:
                return new BootsEffect(tank, effectObject, effectFor, duration);
            case EffectEnum.Slow:
                return new SlowEffect(tank, effectObject, effectFor, duration);
            case EffectEnum.CanHitRocket:
                return new CanHitRocket(tank, effectObject, effectFor, duration);
            default:
                Debug.LogError("Effect name incorrect @@ !");
                return null;
        }
    }
}
