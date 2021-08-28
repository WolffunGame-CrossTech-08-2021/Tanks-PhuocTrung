using UnityEngine;

public class StunEffect : Effect
{
    private TankMovement _tankMovement;
    private float _currentMovevomentSpeed;

    public StunEffect(GameObject tank, EffectObject effect) : base(tank, effect)
    {
        _tankMovement = tank.GetComponent<TankMovement>();
    }

    public override void ActiveEffect()
    {
        base.ActiveEffect();
        _currentMovevomentSpeed = _tankMovement.m_Speed;
        _tankMovement.m_Speed = 0;
    }

    public override void DeactiveEffect()
    {
        base.DeactiveEffect();
        _tankMovement.m_Speed = _currentMovevomentSpeed;
        _currentMovevomentSpeed = 0f;
    }
}
