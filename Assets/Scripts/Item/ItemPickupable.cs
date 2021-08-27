using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ItemPickupable : MonoBehaviour
{
    public ItemObject itemObject;

    private void Start()
    {
        if (itemObject) return;
        Debug.LogError("Scriptable object not assign !");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            itemObject.ActiveItem(other.gameObject);
            Destroy(gameObject);
        }
    }
}