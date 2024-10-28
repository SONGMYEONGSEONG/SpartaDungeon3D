using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public ItemSO _ItemSO;
    public LayerMask PlayerMask;//플레이어만 아이템이 획득되야되기떄문에

    private void OnTriggerEnter(Collider other)
    {
        if(1 << other.gameObject.layer == PlayerMask)
        {
            if (other.TryGetComponent(out PlayerStatus playerStatus))
            {
                switch (_ItemSO.Type)
                {
                    case ItemType.Equipable:
                        GetEquipItem(playerStatus);
                        break;
                    case ItemType.Consumable:
                        GetConsumItem(playerStatus);
                        break;
                }
            }
        }
    }

    private void GetEquipItem(PlayerStatus playerStatus)
    {
        //장착 아이템 획득 코드 
    }

    private void GetConsumItem(PlayerStatus playerStatus)
    {
        foreach(ItemConsumableType Item in _ItemSO.consumableDatas)
        {
            switch (Item.consumableType)
            {
                case ConsumableType.Health:
                    playerStatus.CurHealth = Mathf.Min(playerStatus.CurHealth + Item.value, playerStatus.HealthMax);
                    Debug.Log($"플레이어 HP가 {Item.value} 적용되었습니다.");
                    Debug.Log($"플레이어 HP : {playerStatus.CurHealth} /  {playerStatus.HealthMax}");
                    break;
                case ConsumableType.Stamina:
                    playerStatus.CurHealth = Mathf.Min(playerStatus.CurStamina + Item.value, playerStatus.StaminaMax);
                    Debug.Log($"플레이어 Stamina가 {Item.value} 적용되었습니다.");
                    Debug.Log($"플레이어 HP : {playerStatus.CurStamina} /  {playerStatus.StaminaMax}");
                    break;
            }
        }
    }


}
