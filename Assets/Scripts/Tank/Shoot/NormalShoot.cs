using System.Collections;
using UnityEngine;

public class NormalShoot : IShoot
{
    private int _paramShoot;
    private HomingMissile _homingMissile;
    private ShellExplosion _shellExplosion;

    public NormalShoot(int paramsShoot)
    {
        _paramShoot = paramsShoot;
    }
    
    public void Fire(GameObject tankObject, Transform fireTransform, float force)
    {
        GameObject bullet = BulletObjectPool.Instance.GetPooledObject();
        if (bullet)
        {
            /* CONFIG BULLET */
            
            // Homing Rocket ?
            _homingMissile = bullet.GetComponent<HomingMissile>();
            _homingMissile.enabled = BitExtensions.IsBitSetTo1(_paramShoot, 0);
            
            // Toxins ?
            _shellExplosion = bullet.GetComponent<ShellExplosion>();
            _shellExplosion.isContainToxic = BitExtensions.IsBitSetTo1(_paramShoot, 1);


            bullet.transform.position = fireTransform.position;
            bullet.transform.rotation = fireTransform.rotation;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = force * bullet.transform.forward;
            bullet.transform.SetParent(tankObject.transform);
            bullet.SetActive(true);
        }
    }
}
