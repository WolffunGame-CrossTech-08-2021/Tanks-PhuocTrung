using UnityEngine;

public class BootsItem : Item
{
    public override void ActiveItem(GameObject tank)
    {
        Debug.Log("x2 speed");
        tank.GetComponent<TankMovement>().m_Speed *= 2;
    }
}