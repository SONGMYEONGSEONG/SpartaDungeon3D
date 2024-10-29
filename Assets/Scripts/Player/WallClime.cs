using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallClime : MonoBehaviour
{
    public Transform PlayerTr;
    public float RayDistance = 2.0f;
    private Rigidbody rigid;
    public LayerMask WallLayerMask;

    public bool isCliming = false; // 벽을 오르는 상태

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Ray ray = new Ray(PlayerTr.position, PlayerTr.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, RayDistance, WallLayerMask))
        {
            if (hit.normal.y < 0.1f)  //충돌체의 y축 노말 벡터를 체크하여 수직 벽인지 감지
            {
                isCliming = true;
                rigid.useGravity = false;// 벽에 매달렸으니 떨어지지않게 중력을 끄도록 판정



            }

        }
        else
        {
            isCliming = false;
            rigid.useGravity = true;
        }
    }
}
