using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="DefaultCharacterSO",menuName ="CharacterSO/Default",order =0)]
public class CharacterStatusSO : ScriptableObject
{
    [Header("Status")]
    public string Name;
    public int Health;
    public int Stamina;
}
