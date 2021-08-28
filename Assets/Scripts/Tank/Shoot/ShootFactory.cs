using UnityEngine;

public class ShootFactory : MonoBehaviour
{
    public static void Fire(TankShootingMode mode, GameObject tankObject, Transform fireTransform, float force, int paramsShoot)
    {
        IShoot shoot;
        switch (mode)
        {
            case TankShootingMode.RAPID:
                shoot = new RapidShoot();
                break;
            case TankShootingMode.CONE:
                shoot = new ConeShoot();
                break;

            default:
            case TankShootingMode.NORMAL:
                shoot = new NormalShoot(paramsShoot);
                break;
        }
        
        shoot.Fire(tankObject, fireTransform, force);
    }
}
