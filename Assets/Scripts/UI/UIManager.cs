using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IModuelUI
{
    public void Print(); //UI�� ȭ�鿡 ����մϴ�.
    public void UIUpdate(); //UI ���¸� ������Ʈ �մϴ�.
}

public enum UIKey
{
    PlayerStatusBar = 0,
    InterAction = 1,
}

public class UIManager : Singleton<UIManager>
{
    public Dictionary<UIKey, IModuelUI> UIDict = new Dictionary<UIKey, IModuelUI>();


    protected override void Awake()
    {
        base.Awake();
    }
}
