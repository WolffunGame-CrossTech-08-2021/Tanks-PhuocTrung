using UnityEngine;

public class EffectManager : Singleton<EffectManager>
{
    [SerializeField]
    private EffectObject[] effectObjects;

    public EffectObject[] GetAll()
    {
        return effectObjects;
    }

    public EffectObject Get(EffectEnum effectEnum)
    {
        foreach (var effect in effectObjects)
        {
            if (effect.nameEnum == effectEnum)
                return effect;
        }

        return null;
    }
}
