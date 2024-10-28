using System;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private float curHealth;
    private float curStamina;

    public float CurHealth { get { return curHealth; } set { curHealth = value; } }
    public float CurStamina { get { return curStamina; } set { curStamina = value; } }

    private void Start()
    {
        curHealth = GameManager.Instance.Player.statusSO.Health;
        curStamina = GameManager.Instance.Player.statusSO.Stamina;
    }
}