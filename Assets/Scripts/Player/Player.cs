using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterStatusSO statusSO;
    private PlayerController controller;
    private PlayerStatus status;

    public PlayerController Controller { get { return controller; } }
    public PlayerStatus Status { get { return status; } }

    private void Awake()
    {
        GameManager.Instance.Player = this;
        controller = gameObject.GetComponent<PlayerController>();
        status = gameObject.GetComponent<PlayerStatus>();
    }
}
