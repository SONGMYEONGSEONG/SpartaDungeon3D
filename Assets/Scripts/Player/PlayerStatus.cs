using System;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private float healthMax;
    private float staminaMax;

    private float curHealth;
    private float curStamina;

    public float HealthMax { get => healthMax; set => healthMax = value; }
    public float StaminaMax { get => staminaMax; set => staminaMax = value; }
    public float CurHealth { get => curHealth; set => curHealth = value; }
    public float CurStamina { get => curStamina; set => curStamina = value; }

    private void Start()
    {
        healthMax = GameManager.Instance.Player.statusSO.Health;
        staminaMax = GameManager.Instance.Player.statusSO.Stamina;

        curHealth = healthMax;
        curStamina = staminaMax;
    }


}