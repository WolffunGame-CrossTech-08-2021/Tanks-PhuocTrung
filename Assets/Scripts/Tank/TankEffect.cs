using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TankEffect : MonoBehaviour
{
    private List<Effect> _currentEffects = new List<Effect>();

    private void Update()
    {
        foreach (var effect in _currentEffects.ToList())
            if (!effect.ProcessTick())
                RemoveEffect(effect);
    }

    public void AddEffect(Effect newEffect)
    {
        foreach (var effect in _currentEffects.ToList())
        {
            if (newEffect.GetType() == effect.GetType())
            {
                effect.DeactiveEffect();
                RemoveEffect(effect);
            }
        }

        _currentEffects.Add(newEffect);
    }

    public void RemoveEffect(Effect newEffect)
    {
        _currentEffects.Remove(newEffect);
    }
}
