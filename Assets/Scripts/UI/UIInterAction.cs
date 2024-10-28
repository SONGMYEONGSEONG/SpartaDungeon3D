using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInterAction : MonoBehaviour, IModuelUI
{
    public TextMeshProUGUI InterActableObjName;
    public TextMeshProUGUI InterActableObjDesCription;

    public GameObject InterActionWindow;

    void Start()
    {
        UIManager.Instance.UIDict.Add(UIKey.InterAction, this);
        GameManager.Instance.Player.InterAction.OnEventUIInterActionPopUp += Print;
    }

    public void Print(string name, string desc)
    {
        InterActionWindow.SetActive(true);
        InterActableObjName.text = name;
        InterActableObjDesCription.text = desc;
    }

    public void PopDownWindow()
    {
        InterActionWindow.SetActive(false);
    }

    public void UIUpdate()
    {

    }

    public void Print()
    {
        throw new NotImplementedException();
    }
}
