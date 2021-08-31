using UnityEngine;

[CreateAssetMenu(menuName = "Tanks/Shoot/RapidShoot")]
public class RapidShoot : Shoot
{
    [HideInInspector]
    public int numBullets = 4;
    public override void Fire(GameObject tankObject, float force, int paramShoot)
    {
        // Debug.Log("RapidShoot");
        Transform fireTransform = FindFireTransform(tankObject);
        for (int i = 0; i < numBullets; i++)
        {
            GameObject bullet = BulletObjectPool.Instance.GetPooledObject();
            if (bullet)
            {
                ShellExplosion shellExplosion = bullet.GetComponent<ShellExplosion>();
                shellExplosion.isContainStun = true;
                
                bullet.transform.position = fireTransform.position + (fireTransform.forward * i * 1f);
                bullet.transform.rotation = fireTransform.rotation;
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.velocity = force * bullet.transform.forward;
                bullet.transform.SetParent(tankObject.transform);
                bullet.SetActive(true);
            }
        }
    }
}
