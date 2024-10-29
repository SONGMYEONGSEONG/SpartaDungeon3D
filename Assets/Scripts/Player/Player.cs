﻿using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterStatusSO statusSO;
    private PlayerController controller;
    private PlayerStatus status;
    private InterAction interAction;
    private WallClime wallClime;
    public PlayerController Controller { get { return controller; } }
    public PlayerStatus Status { get { return status; } }
    public InterAction InterAction { get {  return interAction; } }


    private void Awake()
    {
        GameManager.Instance.Player = this;
        controller = gameObject.GetComponent<PlayerController>();
        status = gameObject.GetComponent<PlayerStatus>();
        interAction = gameObject.GetComponent<InterAction>();
        wallClime = gameObject.GetComponent<WallClime>();
    }
}
