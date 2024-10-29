using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using static UnityEditor.Progress;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rigid;
    public PlayerStatus status;


    [Header("Movement")]
    private Vector2 curMoveInput;
    private Vector3 moveDirection;

    [Header("Rotation")]
    public Transform cameraContainer;
    private Vector2 mouseDelta;
    public float MinRotX;
    public float MaxRotX;
    public float LookSencitive;
    private float curRotX;

    [Header("IsGrounded")]
    public float RayDistance;
    public Transform GroundPivot;
    public LayerMask GroundMask;
    private bool jumpAble = false;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        status = GetComponent<PlayerStatus>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // ���ӿ��� ���콺 Ŀ���� ����� �ϴ� �޼���
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        isGrounded();
    }

    private void LateUpdate()
    {
        Look();
    }

    private void Look()
    {
        //��,�Ʒ� ȸ��
        curRotX += mouseDelta.y * LookSencitive;
        curRotX = Mathf.Clamp(curRotX, MinRotX, MaxRotX);
        cameraContainer.localRotation = Quaternion.Euler(-curRotX, 0f, 0f);

        //��,�� ȸ��
        transform.localEulerAngles += new Vector3(0f, mouseDelta.x * LookSencitive, 0f);
    }

    public void Move()
    {
        moveDirection = curMoveInput.y * transform.forward + curMoveInput.x * transform.right;
        moveDirection *= status.CurSpeed;
        moveDirection.y = rigid.velocity.y;

        rigid.velocity = moveDirection;
    }

    public void Jump(float JumpPower)
    {
        rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            curMoveInput = context.ReadValue<Vector2>(); ;
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            curMoveInput = Vector2.zero;
        }
    }

    public void isGrounded()
    {
        Ray ray = new Ray(GroundPivot.position, Vector3.down);

        if (Physics.Raycast(ray, out RaycastHit hit, RayDistance, GroundMask))
        {
            jumpAble = true;
        }
        else
        {
            jumpAble = false;
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        mouseDelta = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        //���� �ִ��� üũ�ϴ� Rat �ڵ� �߰��ؾߵ�
        if (context.phase == InputActionPhase.Started && jumpAble && status.CurStamina >= 10)
        {
            Jump(status.CurJumpPower);
            status.CurStamina = Mathf.Max(0, status.CurStamina - 10);
        }
    }
}
