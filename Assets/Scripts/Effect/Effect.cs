using System.Collections;
using UnityEngine;


public abstract class Effect
{
    public GameObject Tank;
    public EffectObject EffectObject;
    private float _currentDuration;

    public Effect(GameObject tank, EffectObject effect)
    {
        Tank = tank;
        EffectObject = effect;
    }
    
    public bool ProcessTick()
    {
        _currentDuration -= Time.deltaTime;
        if (_currentDuration <= 0)
        {
            DeactiveEffect();
            return false;
        }

        return true;
    }

    public abstract void ActiveEffect();
    public abstract void DeactiveEffect();
}
