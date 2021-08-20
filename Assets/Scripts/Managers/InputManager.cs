using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    private void OnAwake()
    {
        Debug.Log("InputManager.OnAwake");
    }
}
