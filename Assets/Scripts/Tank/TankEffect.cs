using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEffect : MonoBehaviour
{
    List<Effect> currentEffects = new List<Effect>();

    private void Update()
    {
        foreach (Effect effect in currentEffects)
        {
            effect.ProcessTick();
        }
    }

    public void AddEffect(Effect newEffect)
    {
        currentEffects.Add(newEffect);
    }
}
