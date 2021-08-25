using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class TankBotController : MonoBehaviour
{
    public Transform m_FireTransform;
    public NavMeshAgent agent;
    public float coutDownTime = 2f;

    private float elapsedTime = 0f;


    private void Start()
    {
        elapsedTime = Time.time;
    }


    private void Update()
    {
        if (GameManager.Instance.isGameStarted)
            agent.SetDestination(GameManager.Instance.m_Tanks[0].m_Instance.transform.position);
        if (Time.time > elapsedTime && 
            Vector3.Distance(gameObject.transform.position, 
            GameManager.Instance.m_Tanks[0].m_Instance.transform.position) < 20f)
        {
            elapsedTime = Time.time + coutDownTime;
            // Fire();
        }
    }

    private void Fire()
    {
        GameObject bullet = BulletObjectPool.Instance.GetPooledObject();
        if (bullet)
        {
            bullet.transform.position = new Vector3(m_FireTransform.position.x, m_FireTransform.position.y, m_FireTransform.position.z);
            bullet.transform.rotation = new Quaternion(m_FireTransform.rotation.x, m_FireTransform.rotation.y, m_FireTransform.rotation.z, m_FireTransform.rotation.w);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = 15f * new Vector3(bullet.transform.forward.x, bullet.transform.forward.y, bullet.transform.forward.z);
            bullet.transform.SetParent(gameObject.transform);
            bullet.SetActive(true);
        }
    }
}
