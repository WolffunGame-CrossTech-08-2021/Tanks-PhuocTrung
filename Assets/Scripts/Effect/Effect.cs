using System.Collections;
using UnityEngine;


public abstract class Effect
{
    public GameObject Tank;
    public EffectObject EffectObject;
    protected float currentDuration;
    public bool isEffectActivated;

    public Effect(GameObject tank, EffectObject effect, EffectFor effectFor, float duration)
    {
        Tank = tank;
        EffectObject = effect;
        currentDuration = duration;
    }
    
    public virtual bool ProcessTick()
    {
        if (!isEffectActivated)
            return false;
        
        currentDuration -= Time.deltaTime;
        if (currentDuration <= 0)
        {
            DeactiveEffect();
            return false;
        }

        return true;
    }

    public virtual void ActiveEffect()
    {
        isEffectActivated = true;
    }

    public virtual void DeactiveEffect()
    {
        isEffectActivated = false;
    }
}
