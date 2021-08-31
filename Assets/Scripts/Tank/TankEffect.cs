using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TankEffect : MonoBehaviour
{
    private List<Effect> _currentEffects = new List<Effect>();
    private Queue<Effect> _removingEffects = new Queue<Effect>();

    private void Update()
    {
        foreach (Effect effect in _currentEffects)
            if (!effect.ProcessTick())
                _removingEffects.Enqueue(effect);

        // Remove effect here
        while (_removingEffects.Count > 0)
        {
            Effect effect = _removingEffects.Dequeue();
            if (effect == null)
                break;
            RemoveEffect(effect);
        }
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
