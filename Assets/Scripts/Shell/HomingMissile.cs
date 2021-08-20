using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HomingMissile : MonoBehaviour
{
    public LayerMask tankMask;
    public float scanRadius = 50f;
    public float speed = 100f;
    public float rotateSpeed = 200f;

    private Rigidbody rbShell;
    private GameObject tankShoot;

    private void Awake()
    {
        rbShell = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        if (rbShell.transform.parent)
            tankShoot = rbShell.transform.parent.gameObject;
    }


    private void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, scanRadius, tankMask);
        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();

            if (!targetRigidbody)
                break;

            if (colliders[i].gameObject == tankShoot)
                continue;

            rbShell.velocity = rbShell.transform.forward * speed;

            Quaternion rocketTargetRot = Quaternion.LookRotation(targetRigidbody.position - rbShell.transform.position);

            rbShell.MoveRotation(Quaternion.RotateTowards(rbShell.transform.rotation, rocketTargetRot, rotateSpeed));
        }
    }
}
