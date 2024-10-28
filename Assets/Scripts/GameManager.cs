using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private Player player;
    public Player Player
    {
        get { return player; }
        set { player = value; }
    }

    protected override void Awake()
    {
        base.Awake();
    }
}
