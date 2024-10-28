using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipable, //������ ������ ex)����,����,����,��
    Consumable, //�Һ� ������ ex) ����,���ǵ�� 
}

public enum ConsumableType
{
    Health,
    Stamina,
    Speed
}

[System.Serializable]
public struct ItemConsumableType
{
    public ConsumableType consumableType;
    public float value;
    public bool isBuff;
    public float bufTime;
}

[CreateAssetMenu(fileName = "DefaultItemSO", menuName = "ItemSO/Default", order = 0)]
public class ItemSO : ScriptableObject
{
    [Header("Info")]
    public string Name; //������ �̸�
    public string Description; //������ ����

    public ItemType Type;//�������� ����
    public List<ItemConsumableType> consumableDatas; //�Һ�������ΰ�� �ش� Ÿ�Կ� ���� ��ġ�� �����

    
}
