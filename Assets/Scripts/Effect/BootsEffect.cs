using UnityEngine;

public class BootsEffect : Effect
{
    private TankMovement _tankMovement;
    private const int NumSpeedUp = 10;

    public BootsEffect(GameObject tank, EffectObject effect, EffectFor effectFor, float duration) 
        : base(tank, effect, effectFor, duration)
    {
        _tankMovement = tank.GetComponent<TankMovement>();
    }

    public override void ActiveEffect()
    {
        _tankMovement.m_Speed += NumSpeedUp;
    }

    public override void DeactiveEffect()
    {
        _tankMovement.m_Speed -= NumSpeedUp;
    }
}
