using UnityEngine;

public class HealthItem : Item
{
    public override void ActiveItem(GameObject tank)
    {
        TankHealth tankHealth = tank.GetComponent<TankHealth>();
        tankHealth.TakeDamage(- tankHealth.m_StartingHealth / 2);
    }
}
