using System.Collections;
using UnityEngine;

public class NormalShoot : IShoot
{
    public void Fire(GameObject tankObject, Transform fireTransform, float force)
    {
        GameObject bullet = BulletObjectPool.Instance.GetPooledObject();
        if (bullet)
        {
            bullet.transform.position = fireTransform.position;
            bullet.transform.rotation = fireTransform.rotation;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = force * bullet.transform.forward;
            bullet.transform.SetParent(tankObject.transform);
            bullet.SetActive(true);
        }
    }
}