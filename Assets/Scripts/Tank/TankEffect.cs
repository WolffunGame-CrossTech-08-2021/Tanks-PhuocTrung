using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEffect : MonoBehaviour
{
    private List<Effect> _currentEffects = new List<Effect>();

    private void Update()
    {
        foreach (Effect effect in _currentEffects)
        {
            if (!effect.ProcessTick())
                RemoveEffect(effect);
        }
    }

    public void AddEffect(Effect newEffect)
    {
        _currentEffects.Add(newEffect);
    }
    
    public void RemoveEffect(Effect newEffect)
    {
        _currentEffects.Remove(newEffect);
    }
}
