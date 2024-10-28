using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="DefaultCharacterSO",menuName ="CharacterSO/Default",order =0)]
public class CharacterStatusSO : ScriptableObject
{
    [Header("Info")]
    public string Name;
    [Header("Movement Stats")]
    public float Speed;
    public float SpeedMin;
    public float SpeedMax;
    public float JumpPower;
    public float JumpPowerMin;
    public float JumpPowerMax;

    [Header("Condition Stats")]
    public int Health;
    public int HealthMax;
    public int Stamina;
    public int StaminaMax;

}
