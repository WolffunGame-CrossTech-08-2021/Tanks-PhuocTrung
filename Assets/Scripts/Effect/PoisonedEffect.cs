using UnityEngine;

public class PoisonedEffect : Effect
{
    private TankHealth _tankHealth;
    private float _elapsed;
    private readonly float _damageEverySecond;
    
    public PoisonedEffect(GameObject tank, EffectObject effect) : base(tank, effect)
    {
        _tankHealth = tank.GetComponent<TankHealth>();
        _elapsed = 0;
        _damageEverySecond = 2f;
    }

    public override bool ProcessTick()
    {
        _elapsed += Time.deltaTime;
        if (_elapsed >= 0.1f) {
            _elapsed = _elapsed % 0.1f;
            _tankHealth.TakeDamage(_damageEverySecond / 10);
        }

        return base.ProcessTick();
    }
}
