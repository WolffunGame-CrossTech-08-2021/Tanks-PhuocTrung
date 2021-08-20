using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Tank Abiity", menuName ="TankAbility")]
public class Ability : ScriptableObject
{
    public int[] abilities;
    private void Awake()
    {
        Debug.Log("Scriptale Object already loaded !");
    }
}
