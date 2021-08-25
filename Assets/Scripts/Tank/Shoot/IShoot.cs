using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShoot
{
    void Fire(GameObject tankObject, Transform fireTransform, float force);
}
