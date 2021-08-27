using UnityEngine;

public class CanHitPoison : Effect
{
    private TankShooting _tankShooting;
    private TankHealth _tankHealth;
    private float _elapsed;
    
    public CanHitPoison(GameObject tank, EffectObject effect, EffectFor effectFor, float duration)
        : base(tank, effect, effectFor, duration)
    {
        _tankShooting = Tank.GetComponent<TankShooting>();
        _tankHealth = Tank.GetComponent<TankHealth>();
        _elapsed = 0;
    }

    public override bool ProcessTick()
    {
        _elapsed += Time.deltaTime;
        if (_elapsed >= 1f) {
            Debug.Log("adu");
            _elapsed = _elapsed % 1f;
            _tankHealth.TakeDamage(-10f);
        }
        
        currentDuration -= Time.deltaTime;
        if (currentDuration <= 0)
        {
            DeactiveEffect();
            return false;
        }

        return true;
    }

    public override void ActiveEffect()
    {
        _tankShooting.paramsShoot = BitExtensions.SetBitTo1(_tankShooting.paramsShoot, 1);
    }

    public override void DeactiveEffect()
    {
        _tankShooting.paramsShoot = BitExtensions.SetBitTo0(_tankShooting.paramsShoot, 1);
    }
}
