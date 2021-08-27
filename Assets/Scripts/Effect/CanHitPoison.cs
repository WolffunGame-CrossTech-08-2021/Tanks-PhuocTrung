using UnityEngine;

public class CanHitPoison : Effect
{
    private TankShooting _tankShooting;
    private float _elapsed;
    
    public CanHitPoison(GameObject tank, EffectObject effect, EffectFor effectFor, float duration)
        : base(tank, effect, effectFor, duration)
    {
        _tankShooting = Tank.GetComponent<TankShooting>();
        _elapsed = 0;
    }

    public override void ActiveEffect()
    {
        base.ActiveEffect();
        _tankShooting.paramsShoot = BitExtensions.SetBitTo1(_tankShooting.paramsShoot, 1);
    }

    public override void DeactiveEffect()
    {
        base.DeactiveEffect();
        _tankShooting.paramsShoot = BitExtensions.SetBitTo0(_tankShooting.paramsShoot, 1);
    }
}
