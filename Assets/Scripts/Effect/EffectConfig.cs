[System.Serializable]
public class EffectConfig
{
    public EffectObject EffectObjectLogic;
    public float duration;
    public float amount;
    public EffectAddType EffectAddType;
}

public enum EffectAddType {
    AddNew,
    Relay
}
