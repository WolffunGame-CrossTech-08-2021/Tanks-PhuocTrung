using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Tanks/Shoot/ConeShoot")]
public class ConeShoot : Shoot
{
    public int numBullets = 5;
    public float angleCone = 10f;

    private int numBulletsHalf;

    private void Awake()
    {
        numBulletsHalf = numBullets / 2;
    }

    public override void Fire(GameObject tankObject, float force, int paramShoot)
    {
        Transform fireTransform = FindFireTransform(tankObject);
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
