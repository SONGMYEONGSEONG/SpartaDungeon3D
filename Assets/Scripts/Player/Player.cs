using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerController controller;

    private void Start()
    {
        GameManager.Instance.Player = this;
        controller = gameObject.GetComponent<PlayerController>();
    }
}
