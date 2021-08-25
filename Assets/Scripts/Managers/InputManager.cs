using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    private float movementInputValue;
    private float turnInputValue;

    private void Update()
    {
        movementInputValue = Input.GetAxis("Vertical1");
        turnInputValue = Input.GetAxis("Horizontal1");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Shooting
            // Debug.Log("Shooting");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            // Change weapon
            TankShooting currentTankShooting = GameManager.Instance
                .m_Tanks[GameManager.Instance.m_TankControlId - 1].m_Shooting;
            TankShootingMode currentMode = currentTankShooting.m_ShootingMode;
            currentTankShooting.m_ShootingMode = currentMode.Next();
        }
    }
}
