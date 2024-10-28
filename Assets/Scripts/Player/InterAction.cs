using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterAction : MonoBehaviour
{
    public LayerMask layerMask;
    public float RayDistance;

    private RaycastHit hit;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

        if(Physics.Raycast(ray, out hit, RayDistance, layerMask))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
