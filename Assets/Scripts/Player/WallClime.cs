using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallClime : MonoBehaviour
{
    public Transform PlayerTr;
    public float RayDistance = 2.0f;
    private Rigidbody rigid;
    public LayerMask WallLayerMask;

    public bool isCliming = false; // ���� ������ ����

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Ray ray = new Ray(PlayerTr.position, PlayerTr.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, RayDistance, WallLayerMask))
        {
            if (hit.normal.y < 0.1f)  //�浹ü�� y�� �븻 ���͸� üũ�Ͽ� ���� ������ ����
            {
                isCliming = true;
                rigid.useGravity = false;// ���� �Ŵ޷����� ���������ʰ� �߷��� ������ ����



            }

        }
        else
        {
            isCliming = false;
            rigid.useGravity = true;
        }
    }
}
