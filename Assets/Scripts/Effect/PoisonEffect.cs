using UnityEngine;

public class PoisonEffect : Effect
{
    private TankHealth _tankHealth;
    private float _elapsed;
    
    public PoisonEffect(GameObject tank, EffectObject effect, EffectFor effectFor, float duration)
        : base(tank, effect, effectFor, duration)
    {
        _tankHealth = Tank.GetComponent<TankHealth>();
        _elapsed = 0;
    }

    public override bool ProcessTick()
    {
        _elapsed += Time.deltaTime;
        if (_elapsed >= 0.1f) {
            _elapsed = _elapsed % 0.1f;
            _tankHealth.TakeDamage(1f);
        }

        return base.ProcessTick();
    }
}
