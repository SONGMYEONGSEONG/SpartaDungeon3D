using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private Rigidbody rigid;
    public float Speed;
    public Vector3 StartPos;
    public Vector3 EndPos;

    private float elispedTime = 0f;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        transform.position = StartPos;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        elispedTime += Time.fixedDeltaTime;

        transform.position = Vector3.Lerp(StartPos, EndPos, Speed * elispedTime);

        if (Vector3.Distance(transform.position, EndPos) < 0.1f)
        {
            Swap();
            elispedTime = 0f;
        }
    }

    private void Swap()
    {
        Vector3 tmp = EndPos;
        EndPos = StartPos;
        StartPos = tmp;
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.transform.SetParent(null);
    }
}
