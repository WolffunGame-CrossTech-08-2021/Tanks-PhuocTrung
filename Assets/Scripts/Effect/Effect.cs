using System.Collections;
using UnityEngine;


public abstract class Effect
{
    public GameObject Tank;
    public EffectObject EffectObject;
    protected float currentDuration;

    public Effect(GameObject tank, EffectObject effect, EffectFor effectFor, float duration)
    {
        Tank = tank;
        EffectObject = effect;
        currentDuration = duration;
    }
    
    public virtual bool ProcessTick()
    {
        currentDuration -= Time.deltaTime;
        if (currentDuration <= 0)
        {
            DeactiveEffect();
            return false;
        }

        return true;
    }

    public abstract void ActiveEffect();
    public abstract void DeactiveEffect();
}
