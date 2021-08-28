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
            case EffectEnum.Stun:
                return new StunEffect(tank, effectObject);
            case EffectEnum.CanHitRocket:
                return new CanHitRocket(tank, effectObject);
            case EffectEnum.CanHitPoison:
                return new CanHitPoison(tank, effectObject);
            case EffectEnum.Poisoned:
                return new PoisonedEffect(tank, effectObject);
            default:
                Debug.LogError("Effect name incorrect @@ !");
                return null;
        }
    }
}
