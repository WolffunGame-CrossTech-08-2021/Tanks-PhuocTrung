using UnityEngine;

public abstract class Shoot : ScriptableObject
{
    public static Transform FindFireTransform(GameObject tank)
    {
        Transform fireTransform = tank.transform.Find("FireTransform");
        return fireTransform;
    }

    public abstract void Fire(GameObject tankObject, float force, int paramShoot);
}