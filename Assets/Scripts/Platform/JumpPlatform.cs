using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public float JumpPlatformPower = 200f;

    public void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            //player.Controller.Jump(Vector3.up * JumpPlatformPower,ForceMode.Impulse);
            player.Controller.Jump(JumpPlatformPower);
        }
    }
}
