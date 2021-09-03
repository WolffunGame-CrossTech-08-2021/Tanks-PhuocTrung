using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObjectPool : Singleton<BulletObjectPool>
{
    [HideInInspector]
    public Queue<GameObject> pool;
    public GameObject objectToPool;
    public int amount;

    private void Awake()
    {
        pool = new Queue<GameObject>(amount);
        GameObject tmp;
        for(int i = 0; i < amount; i++)
        {
            tmp = Instantiate(objectToPool, transform);
            tmp.SetActive(false);
            pool.Enqueue(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        } else
        {
            Debug.Log("Instantiate bullet");
            GameObject tmp = Instantiate(objectToPool, transform);
            pool.Enqueue(tmp);
            return tmp;
        }
    }

    public void DeActiveObject(GameObject bullet)
    {
        bullet.SetActive(false);
        pool.Enqueue(bullet);
    }
}
