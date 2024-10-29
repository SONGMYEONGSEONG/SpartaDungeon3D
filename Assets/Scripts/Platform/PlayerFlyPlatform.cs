using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFlyPlatform : MonoBehaviour
{
    public LayerMask PlayerLayerMask;
    public float Angle = 45.0f;
    public float RunPlatformTime = 2.0f;
    public float curTimer = 0.0f;
    public float MoveSpeed = 6;
    public float JumpPower = 50;

    public void RunPlatform(PlayerController controller)
    {
        //TO DO CODE : �÷��̾� �߻�
        

        Quaternion rotZ = Quaternion.AngleAxis(Angle, Vector3.right);
        Vector3 dir = rotZ * (transform.up);
        Debug.Log($"{dir} Player �߻�");

        controller.ExtraDir = new Vector3(dir.x, 0, dir.y) * MoveSpeed;
        controller.Jump(dir,JumpPower);

    }

}
