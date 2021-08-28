using UnityEngine;

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
            Debug.Log("Pickup " + itemObject);
            itemObject.ActiveItem(other.gameObject);
            // Destroy(gameObject);
            gameObject.transform.position = new Vector3(Random.Range(-30, 30), 1.5f, Random.Range(-30, 30));
        }
    }
}
