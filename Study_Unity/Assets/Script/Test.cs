using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Awake�� ���� �ѹ��� �����մϴ�");

    }
    void OnEnable()
    {
        Debug.Log("OnEnable�� Ȱ��ȭ �� ������ �����մϴ�");
        Random.InitState(2);
        Debug.Log(Random.Range(1, 100));
       
    }
    void Start()

    {
        Debug.Log("Start�� OnEnable �������� �����մϴ�");
    }
    void Update()
    {
        Debug.Log("�� ������ ���� �����մϴ�");
        

    }

    void OnDisable()
    {
        Debug.Log("OnDisable�� ��Ȱ��ȭ �� ������ �����մϴ�");
    }
    void OnDestroy()
    {
        Debug.Log("OnDestroy�� ���� ������Ʈ�� �ı��� �� �����մϴ�");
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
    void MonsterSpawn() // ����
    {
        B.SetLevel(A.Level());
    }
} 
*/