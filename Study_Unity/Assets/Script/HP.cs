using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public TextMeshProUGUI txt_hp; //  UI 텍스트 표시
    public TextMeshProUGUI Text_box; // UI 텍스트 표시용 박스
    public Image img_hpbar; // Image의 타입이 3개가있다 그중 UI를 선택

    public int MaxHP; // 최대 체력
    int NowHP; // 현재 체력

    public int Damage; // 데미지
    public int Heal; // 회복량
    

    private void Awake()
    {
        refeshUI(); // UI 초기화
    }

    public void OnclickDamage()  //데미지

    {
        Damage = Random.Range(5, 21);
        Debug.Log($"데미지: {Damage}"); // 데미지 출력
        NowHP -= Damage; // 데미지만큼 현재 체력 감소
        if (NowHP < 0) // 현재 체력이 0보다 작아지면
        {
            NowHP = 0; // 현재 체력을 0으로 설정
        }

        ResultUI(); // 체력바 업데이트
        Text_box.text = $"데미지: {Damage} 만큼의 피해를 받았습니다."; // UI 텍스트 업데이트

    }

    public void OnclickHeal() //회복
    {
        Heal = Random.Range(5, 21);
        Debug.Log($"회복량: {Heal}"); // 회복량 출력
        NowHP += Heal; // 회복량만큼 현재 체력 증가
        if (NowHP > MaxHP) // 현재 체력이 최대 체력을 초과하면               
        {
            NowHP = MaxHP; // 현재 체력을 최대 체력으로 설정
        }
        Text_box.text = $"회복량: {Heal} 만큼의 피를 회복 하셨습니다."; // UI 텍스트 업데이트
        ResultUI(); // 체력바 업데이트

    }
    void ResultUI()
    {
        img_hpbar.fillAmount = (float)NowHP / MaxHP; // 체력바 업데이트
        txt_hp.text = $"{NowHP} / {MaxHP}"; // UI 텍스트 업데이트

    }
    void refeshUI()
    {
        MaxHP = 100; // 최대 체력 초기화
        NowHP = MaxHP; // 현재 체력은 최대 체력으로 초기화
        txt_hp.text = $"{NowHP} / {MaxHP}"; // UI 텍스트 초기화


    }

}
