using UnityEngine;

public class CanHitRocket : Effect
{
    private const int BitPosition = 0;
    private TankShooting _tankShooting;
    public CanHitRocket(GameObject tank, EffectObject effect) : base(tank, effect)
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
