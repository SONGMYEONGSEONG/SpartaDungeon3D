using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlyPlatformCollider : MonoBehaviour
{
    public PlayerFlyPlatform parentObject;

    private void Awake()
    {
        parentObject = GetComponentInParent<PlayerFlyPlatform>();
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(1 << collision.gameObject.layer == parentObject.PlayerLayerMask)
    //    {
    //        parentObject.curTimer = 0.0f;
    //    }
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    if (1 << collision.gameObject.layer == parentObject.PlayerLayerMask)
    //    {
    //        parentObject.curTimer += Time.deltaTime;
    //        if(parentObject.RunPlatformTime <= parentObject.curTimer)
    //        {
    //            parentObject.RunPlatform();
    //        }
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (1 << other.gameObject.layer == parentObject.PlayerLayerMask)
        {
            parentObject.curTimer = 0.0f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (1 << other.gameObject.layer == parentObject.PlayerLayerMask)
        {
            parentObject.curTimer += Time.deltaTime;
            if (parentObject.RunPlatformTime <= parentObject.curTimer)
            {
                
                if (other.TryGetComponent(out PlayerController controller))
                {
                    parentObject.RunPlatform(controller);
                }
                else
                {
                    Debug.Log($"�ش� �ݸ����� ������ٵ� �������� ���� {other.name}");
                }
            }
        }
    }
}
