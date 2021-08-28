using System.Collections;
using UnityEngine;


public abstract class Effect
{
    public readonly GameObject tank;
    public EffectObject effectObject;
    protected float currentDuration;
    public bool isEffectActivated;

    public Effect(GameObject tank, EffectObject effect)
    {
        this.tank = tank;
        effectObject = effect;
        currentDuration = effect.duration;
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
