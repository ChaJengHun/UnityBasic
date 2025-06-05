using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Awake는 최초 한번만 실행합니다");

    }
    void OnEnable()
    {
        Debug.Log("OnEnable은 활성화 될 때마다 실행합니다");
        Random.InitState(2);
        Debug.Log(Random.Range(1, 100));
       
    }
    void Start()

    {
        Debug.Log("Start는 OnEnable 다음으로 실행합니다");
    }
    void Update()
    {
        Debug.Log("매 프레임 마다 실행합니다");
        

    }

    void OnDisable()
    {
        Debug.Log("OnDisable은 비활성화 될 때마다 실행합니다");
    }
    void OnDestroy()
    {
        Debug.Log("OnDestroy는 게임 오브젝트가 파괴될 때 실행합니다");
    }

}
/*
public class Player
{
    private int playerLevel = 10;

    public int Level()
    {
        return playerLevel;
    }
}

public class Monster 
{
    private int monsterLevel;

    public void SetLevel(int _playerLevel)
    {
        monsterLevel = _playerLevel;
    }
}

public class Game
{
    Player A;
    Monster B;
    void MonsterSpawn() // 몬스터
    {
        B.SetLevel(A.Level());
    }
} 
*/