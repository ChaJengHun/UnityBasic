using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Practice : MonoBehaviour
{
    private string Name = "������";
    private bool Gender = false;
    private int Height = 173;
    private float Height2 = 1f;
    private string Hobby = "����";
    private string Hobby2 = "��ȭ ����";
    private string Hobby3 = "�ִ� ����";
    private string Hobby4 = "�����";
    private string MBTI = "INTJ";
    private string FavoriteFood = "ġŲ";
    private string FavoriteGameGenre = "�α׶���ũ";
    private string FavoriteGame = "Master Duel";
    private string FavoriteAnime = "��ȥ";
    private string FavoriteAnimal = "������� �Ƹӵ� ��Ųũ";

   
    private void Awake()
    {
        Debug.Log($"�̸�: {Name}");

    }
    void OnEnable()
    {
        Debug.Log("����:" + Random.Range(1, 30));
     

        Debug.Log($"Ű : {Height}.{Height2}");

        if (!Gender)
        {
            Debug.Log("����: ����");
        }

        else
        {
            Debug.Log("����: ����");
        }
    



    }
    private void Start()
    {
        PrintInfo();
    }
    public void PrintInfo()
    {
        Debug.Log($"���: {Hobby}, {Hobby2}, {Hobby3}, {Hobby4}");
        Debug.Log("��̴� ������ �����ϴ�/n" + Hobby + ", " + Hobby2 + ", " + Hobby3 + ", " + Hobby4);
        Debug.Log($"MBTI: {MBTI}");
        Debug.Log($"�����ϴ� ����: {FavoriteFood}");
        Debug.Log($"�����ϴ� ���� �帣: {FavoriteGameGenre}");
        Debug.Log($"�����ϴ� ����: {FavoriteGame}");
        Debug.Log($"�����ϴ� �ִ�: {FavoriteAnime}");
        Debug.Log($"�����ϴ� ����: {FavoriteAnimal}");

    }













}
