using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultInterActableSO", menuName = "InterActableSO/Default", order = 0)]
public class InterActableSO : ScriptableObject
{
    [Header("Info")]
    public string Name; //상호작용 오브젝트 이름
    public string Description; //상호작용 오브젝트 설명

}
