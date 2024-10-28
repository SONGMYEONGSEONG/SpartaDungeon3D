using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

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
                    break;

                case ConsumableType.Stamina:
                    playerStatus.CurStamina = Mathf.Min(playerStatus.CurStamina + Item.value, playerStatus.StaminaMax);
                    break;

                case ConsumableType.Speed:
                    playerStatus.CurSpeed = Mathf.Min(playerStatus.CurSpeed + Item.value, playerStatus.SpeedMax);
                    break;
            }

            if(Item.isBuff)
            {
                StartCoroutine(UseBuff(playerStatus, Item));
            }
        }
    }

    IEnumerator UseBuff(PlayerStatus playerStatus, ItemConsumableType Item)
    {
        yield return new WaitForSeconds(Item.bufTime);

        switch (Item.consumableType)
        {
            case ConsumableType.Health:
                playerStatus.CurHealth = Mathf.Max(0, playerStatus.CurHealth - Item.value);
                break;

            case ConsumableType.Stamina:
                playerStatus.CurStamina = Mathf.Max(0, playerStatus.CurStamina - Item.value);
                break;

            case ConsumableType.Speed:
                playerStatus.CurSpeed = Mathf.Max(playerStatus.SpeedMin, playerStatus.CurSpeed - Item.value);
                break;
        }
    }

}
