using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObjectPool : Singleton<BulletObjectPool>
{
    public List<GameObject> pooledObjects = new List<GameObject>(10);
    public Queue<GameObject> freePool = new Queue<GameObject>(10);
    public GameObject objectToPool;
    public int amountToPool;

    private void Start()
    {
        // pooledObjects = new Queue<GameObject>();
        GameObject tmp;
        for(int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool, transform);
            tmp.SetActive(false);
            // pooledObjects.Enqueue(tmp);
            freePool.Enqueue(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        if (freePool.Count > 0)
        {
            GameObject obj = freePool.Dequeue();
            obj.SetActive(true);
            return obj;
        } else
        {
            GameObject tmp = Instantiate(objectToPool, transform);
            pooledObjects.Add(tmp);
            return tmp;
        }

        /*
        for(int i = 0; i < amountToPool; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        GameObject tmp = Instantiate(objectToPool);
        pooledObjects.Add(tmp);
        return tmp;*/
    }

    public static IEnumerator DeactiveObject(GameObject _gameObject, float timeDelay)
    {

        yield return new WaitForSeconds(timeDelay);
        _gameObject.SetActive(false);

        
    }

    public IEnumerator DeactiveObjectWithTime(GameObject gameObject, float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
        freePool.Enqueue(gameObject);
        pooledObjects.Remove(gameObject);
    }
}
