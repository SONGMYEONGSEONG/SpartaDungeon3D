using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipable, //장착이 가능한 ex)모자,갑옷,도끼,검
    Consumable, //소비가 가능한 ex) 음식,포션등등 
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
    public string Name; //아이템 이름
    public string Description; //아이템 설명

    public ItemType Type;//아이템의 종류
    public List<ItemConsumableType> consumableDatas; //소비아이템인경우 해당 타입에 맞춰 수치가 적용됨

    
}
