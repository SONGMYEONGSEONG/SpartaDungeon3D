using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultInterActableSO", menuName = "InterActableSO/Default", order = 0)]
public class InterActableSO : ScriptableObject
{
    [Header("Info")]
    public string Name; //��ȣ�ۿ� ������Ʈ �̸�
    public string Description; //��ȣ�ۿ� ������Ʈ ����

}
