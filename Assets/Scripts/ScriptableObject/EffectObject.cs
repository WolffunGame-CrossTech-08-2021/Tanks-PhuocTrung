using UnityEngine;

[CreateAssetMenu(menuName = "Tanks/Effect")]
public class EffectObject : ScriptableObject
{
    public new string name;
    public EffectEnum nameEnum;
    public EffectFor effectFor;
    public float duration;

    public void ActiveEffect(GameObject tank)
    {
        EffectFactory.GetEffect(nameEnum, tank, this).ActiveEffect();
    }
}
