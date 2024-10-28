using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterAction : MonoBehaviour
{
    public event Action<string,string> OnEventUIInterActionPopUp;

    public LayerMask layerMask;
    public float RayDistance;

    private RaycastHit hit;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

        if(Physics.Raycast(ray, out hit, RayDistance, layerMask))
        {     
            OnEventUIInterActionPopUp?.Invoke(hit.transform.name,"설명 테스트");
        }
        else
        {
            UIInterAction UiWindow = UIManager.Instance.UIDict[UIKey.InterAction] as UIInterAction;
            UiWindow.PopDownWindow();
        }
    }
}
