using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Practice : MonoBehaviour
{
    private string Name = "차정훈";
    private bool Gender = false;
    private int Height = 173;
    private float Height2 = 1f;
    private string Hobby = "게임";
    private string Hobby2 = "만화 감상";
    private string Hobby3 = "애니 감상";
    private string Hobby4 = "프라모델";
    private string MBTI = "INTJ";
    private string FavoriteFood = "치킨";
    private string FavoriteGameGenre = "로그라이크";
    private string FavoriteGame = "Master Duel";
    private string FavoriteAnime = "은혼";
    private string FavoriteAnimal = "레드아이 아머드 스킨크";

   
    private void Awake()
    {
        Debug.Log($"이름: {Name}");

    }
    void OnEnable()
    {
        Debug.Log("나이:" + Random.Range(1, 30));
     

        Debug.Log($"키 : {Height}.{Height2}");

        if (!Gender)
        {
            Debug.Log("성별: 남성");
        }

        else
        {
            Debug.Log("성별: 여성");
        }
    



    }
    private void Start()
    {
        PrintInfo();
    }
    public void PrintInfo()
    {
        Debug.Log($"취미: {Hobby}, {Hobby2}, {Hobby3}, {Hobby4}");
        Debug.Log("취미는 다음과 같습니다/n" + Hobby + ", " + Hobby2 + ", " + Hobby3 + ", " + Hobby4);
        Debug.Log($"MBTI: {MBTI}");
        Debug.Log($"좋아하는 음식: {FavoriteFood}");
        Debug.Log($"좋아하는 게임 장르: {FavoriteGameGenre}");
        Debug.Log($"좋아하는 게임: {FavoriteGame}");
        Debug.Log($"좋아하는 애니: {FavoriteAnime}");
        Debug.Log($"좋아하는 동물: {FavoriteAnimal}");

    }













}
