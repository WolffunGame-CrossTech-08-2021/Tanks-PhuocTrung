using UnityEngine;

public class CanHitRocket : Effect
{
    private TankShooting _tankShooting;
    public CanHitRocket(GameObject tank, EffectObject effect, EffectFor effectFor, float duration)
        : base(tank, effect, effectFor, duration)
    {
        _tankShooting = Tank.GetComponent<TankShooting>();
    }

    public override void ActiveEffect()
    {
        _tankShooting.paramsShoot = BitExtensions.SetBitTo1(_tankShooting.paramsShoot, 0);
    }

    public override void DeactiveEffect()
    {
        _tankShooting.paramsShoot = BitExtensions.SetBitTo0(_tankShooting.paramsShoot, 0);
    }
}
