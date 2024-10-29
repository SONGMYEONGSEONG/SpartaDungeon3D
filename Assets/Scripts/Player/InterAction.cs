using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraType
{
    FPS =0,
    TPS =1,
}


public class InterAction : MonoBehaviour
{
    public event Action<string, string> OnEventUIInterActionPopUp;

    public LayerMask layerMask;
    public float RayDistance;

    private RaycastHit hit;

    private void Update()
    {
        Ray ray;
        if (GameManager.Instance.Player.cameraType == CameraType.TPS) //3인칭일때
        {
             RayDistance = 10.0f;
             ray = new Ray(GameManager.Instance.Player.transform.position, GameManager.Instance.Player.transform.forward);
        }
        else //1인칭일때
        {
            RayDistance = 3.0f;
            ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        }
        if (Physics.Raycast(ray, out hit, RayDistance, layerMask))
        {
            OnEventUIInterActionPopUp?.Invoke(hit.transform.name, "설명 테스트");
        }
        else
        {
            UIInterAction UiWindow = UIManager.Instance.UIDict[UIKey.InterAction] as UIInterAction;
            UiWindow.PopDownWindow();
        }
    }
}
