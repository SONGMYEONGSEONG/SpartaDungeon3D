using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerStatusBar : MonoBehaviour, IModuelUI
{
    public Image HealthBar;
    public Image StaminaBar;

    // Start is called before the first frame update
    void Start()
    {
        UIManager.Instance.UIDict.Add(UIKey.PlayerStatusBar, this);
    }

    void Update()
    {
        UIUpdate(); // ���߿� �ڷ�ƾ���� ���� �Ұ� 
    }

    public void Print()
    {

    }

    public void UIUpdate()
    {
        HealthBar.fillAmount = GameManager.Instance.Player.Status.CurHealth / GameManager.Instance.Player.Status.HealthMax;
        StaminaBar.fillAmount = GameManager.Instance.Player.Status.CurStamina / GameManager.Instance.Player.Status.StaminaMax;
    }
}
