using System.Collections;
using UnityEngine;
public class SlowEffect : Effect
{
    private TankMovement _tankMovement;
    private const int NumSpeedUp = -10;

    public SlowEffect(GameObject tank, EffectObject effect) : base(tank, effect)
    {
        _tankMovement = tank.GetComponent<TankMovement>();
    }

    public override void ActiveEffect()
    {
        base.ActiveEffect();
        _tankMovement.m_Speed += NumSpeedUp;
    }

    public override void DeactiveEffect()
    {
        base.DeactiveEffect();
        _tankMovement.m_Speed -= NumSpeedUp;
    }
}
