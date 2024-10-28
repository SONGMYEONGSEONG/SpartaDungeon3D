using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject(typeof(GameManager).Name + "Auto");
                    instance = obj.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance == this) //�����ϴ� �ν��Ͻ��� �ڱ�� ���� �����ϰ�� �ڽ��� �ı�
            {
                Destroy(gameObject);
            }
        }
    }

    private Player player;
    public Player Player
    {
        get { return player; }
        set { player = value; }
    }

    
}
