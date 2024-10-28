using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public ItemSO _ItemSO;
    public LayerMask PlayerMask;//�÷��̾ �������� ȹ��ǾߵǱ⋚����

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
        //���� ������ ȹ�� �ڵ� 
    }

    private void GetConsumItem(PlayerStatus playerStatus)
    {
        foreach(ItemConsumableType Item in _ItemSO.consumableDatas)
        {
            switch (Item.consumableType)
            {
                case ConsumableType.Health:
                    playerStatus.CurHealth = Mathf.Min(playerStatus.CurHealth + Item.value, playerStatus.HealthMax);
                    Debug.Log($"�÷��̾� HP�� {Item.value} ����Ǿ����ϴ�.");
                    Debug.Log($"�÷��̾� HP : {playerStatus.CurHealth} /  {playerStatus.HealthMax}");
                    break;
                case ConsumableType.Stamina:
                    playerStatus.CurHealth = Mathf.Min(playerStatus.CurStamina + Item.value, playerStatus.StaminaMax);
                    Debug.Log($"�÷��̾� Stamina�� {Item.value} ����Ǿ����ϴ�.");
                    Debug.Log($"�÷��̾� HP : {playerStatus.CurStamina} /  {playerStatus.StaminaMax}");
                    break;
            }
        }
    }


}
