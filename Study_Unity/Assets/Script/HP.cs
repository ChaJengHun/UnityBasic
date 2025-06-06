using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    public TextMeshProUGUI txt_hp; //  UI �ؽ�Ʈ ǥ��
    public TextMeshProUGUI Text_box; // UI �ؽ�Ʈ ǥ�ÿ� �ڽ�
    public Image img_hpbar; // Image�� Ÿ���� 3�����ִ� ���� UI�� ����

    public int MaxHP; // �ִ� ü��
    int NowHP; // ���� ü��

    public int Damage; // ������
    public int Heal; // ȸ����
    

    private void Awake()
    {
        refeshUI(); // UI �ʱ�ȭ
    }

    public void OnclickDamage()  //������

    {
        Damage = Random.Range(5, 21);
        Debug.Log($"������: {Damage}"); // ������ ���
        NowHP -= Damage; // ��������ŭ ���� ü�� ����
        if (NowHP < 0) // ���� ü���� 0���� �۾�����
        {
            NowHP = 0; // ���� ü���� 0���� ����
        }

        ResultUI(); // ü�¹� ������Ʈ
        Text_box.text = $"������: {Damage} ��ŭ�� ���ظ� �޾ҽ��ϴ�."; // UI �ؽ�Ʈ ������Ʈ

    }

    public void OnclickHeal() //ȸ��
    {
        Heal = Random.Range(5, 21);
        Debug.Log($"ȸ����: {Heal}"); // ȸ���� ���
        NowHP += Heal; // ȸ������ŭ ���� ü�� ����
        if (NowHP > MaxHP) // ���� ü���� �ִ� ü���� �ʰ��ϸ�               
        {
            NowHP = MaxHP; // ���� ü���� �ִ� ü������ ����
        }
        Text_box.text = $"ȸ����: {Heal} ��ŭ�� �Ǹ� ȸ�� �ϼ̽��ϴ�."; // UI �ؽ�Ʈ ������Ʈ
        ResultUI(); // ü�¹� ������Ʈ

    }
    void ResultUI()
    {
        img_hpbar.fillAmount = (float)NowHP / MaxHP; // ü�¹� ������Ʈ
        txt_hp.text = $"{NowHP} / {MaxHP}"; // UI �ؽ�Ʈ ������Ʈ

    }
    void refeshUI()
    {
        MaxHP = 100; // �ִ� ü�� �ʱ�ȭ
        NowHP = MaxHP; // ���� ü���� �ִ� ü������ �ʱ�ȭ
        txt_hp.text = $"{NowHP} / {MaxHP}"; // UI �ؽ�Ʈ �ʱ�ȭ


    }

}
