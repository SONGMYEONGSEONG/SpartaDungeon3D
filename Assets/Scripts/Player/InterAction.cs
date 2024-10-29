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
    private string targetName;
    private string targetDescription;

    private void Update()
    {
        Ray ray;
        if (GameManager.Instance.Player.cameraType == CameraType.TPS) //3ÀÎÄªÀÏ¶§
        {
             RayDistance = 10.0f;
             ray = new Ray(GameManager.Instance.Player.transform.position, GameManager.Instance.Player.transform.forward);
        }
        else //1ÀÎÄªÀÏ¶§
        {
            RayDistance = 3.0f;
            ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        }


        if (Physics.Raycast(ray, out hit, RayDistance, layerMask))
        {
            targetName = hit.transform.GetComponent<InterActableObject>().ObjectSO.Name;
            targetDescription = hit.transform.GetComponent<InterActableObject>().ObjectSO.Description;

            OnEventUIInterActionPopUp?.Invoke(targetName, targetDescription);
        }
        else
        {
            UIInterAction UiWindow = UIManager.Instance.UIDict[UIKey.InterAction] as UIInterAction;
            UiWindow.PopDownWindow();
        }
    }
}
