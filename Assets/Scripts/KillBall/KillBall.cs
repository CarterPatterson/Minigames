using System;
using UnityEngine;

public class KillBall : MonoBehaviour
{
    private SphereCollider collider;

    private void Start()
    {
        collider = gameObject.GetComponent(typeof(SphereCollider)) as SphereCollider;

        if (collider == null)
        {
            Debug.LogError("No collider for KillBall found");
        }
    }

    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetType() == typeof(CapsuleCollider))
        {
            Destroy(collision.gameObject);
        }
    }
}
