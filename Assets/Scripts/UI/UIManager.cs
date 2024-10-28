using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IModuelUI
{
    public void Print(); //UI를 화면에 출력합니다.
    public void UIUpdate(); //UI 상태를 업데이트 합니다.
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
