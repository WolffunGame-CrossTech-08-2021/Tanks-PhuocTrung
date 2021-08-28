using UnityEngine;

public class CanHitPoison : Effect
{
    private const int BitPosition = 1;
    private readonly TankShooting _tankShooting;

    public CanHitPoison(GameObject tank, EffectObject effect) : base(tank, effect)
    {
        _tankShooting = tank.GetComponent<TankShooting>();
    }

    public override void ActiveEffect()
    {
        base.ActiveEffect();
        _tankShooting.paramsShoot = BitExtensions.SetBitTo1(_tankShooting.paramsShoot, BitPosition);
    }

    public override void DeactiveEffect()
    {
        base.DeactiveEffect();
        _tankShooting.paramsShoot = BitExtensions.SetBitTo0(_tankShooting.paramsShoot, BitPosition);
    }
}
