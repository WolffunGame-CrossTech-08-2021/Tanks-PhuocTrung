using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Tanks/Shoot/BaseShoot")]
public class BaseShoot : Shoot
{
    public override void Fire(GameObject tankObject, float force, int paramShoot)
    {
        Transform fireTransform = FindFireTransform(tankObject);
        GameObject bullet = BulletObjectPool.Instance.GetPooledObject();
        if (bullet)
        {
            /* CONFIG BULLET */

            // Homing Rocket ?
            HomingMissile homingMissile = bullet.GetComponent<HomingMissile>();
            homingMissile.enabled = BitExtensions.IsBitSetTo1(paramShoot, 0);

            // Toxins ?
            ShellExplosion shellExplosion = bullet.GetComponent<ShellExplosion>();
            shellExplosion.isContainToxic = BitExtensions.IsBitSetTo1(paramShoot, 1);


            bullet.transform.position = fireTransform.position;
            bullet.transform.rotation = fireTransform.rotation;

            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = force * bullet.transform.forward;
            bullet.transform.SetParent(tankObject.transform);
            bullet.SetActive(true);
        }
    }
}