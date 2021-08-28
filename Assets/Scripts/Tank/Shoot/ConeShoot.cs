using System.Collections;
using UnityEngine;

public class ConeShoot : IShoot
{
    public int numBullets = 5;
    public float angleCone = 10f;

    private int numBulletsHalf;

    public ConeShoot()
    {
        numBulletsHalf = numBullets / 2;
    }

    public void Fire(GameObject tankObject, Transform fireTransform, float force)
    {
        for (int i = -numBulletsHalf; i <= numBulletsHalf; i++)
        {
            Vector3 bulletRotaion = fireTransform.rotation.eulerAngles;
            bulletRotaion.y += angleCone * i;

            GameObject bullet = BulletObjectPool.Instance.GetPooledObject();
            if (bullet)
            {
                ShellExplosion shellExplosion = bullet.GetComponent<ShellExplosion>();
                shellExplosion.isContainSlow = true;
                
                bullet.transform.position = fireTransform.position;
                bullet.transform.rotation = Quaternion.Euler(bulletRotaion);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.velocity = force * bullet.transform.forward;
                bullet.transform.SetParent(tankObject.transform);
                bullet.SetActive(true);
            }
        }
    }
}
