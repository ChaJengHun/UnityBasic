using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Text_Scp : MonoBehaviour
{
    private string Name = "������";
    private bool Gender = false;
    private string Hobby = "����";
    private string Hobby2 = "��ȭ ����";
    private string Hobby3 = "�ִ� ����";
    private string Hobby4 = "�����";
    private string MBTI = "INTJ";
    private string FavoriteChar = "ȣ��";
    private string FavoriteChar1 = "������ ���̹�";
    private string FavoriteChar2 = "������ ����";
    private string FavoriteChar3 = "ŸŸ�� �ڰ���";
    private string FavoriteGameGenre = "�α׶���ũ";
    private string FavoriteGame = "Master Duel";
    private string FavoriteAnime = "��ȥ";
    private string FavoriteAnimal = "Red eyed armored skink";

    public TextMeshProUGUI Txt_Text;
    
    public void OnClickButtonName()
    {
        
        Txt_Text.text = $"���̸��� {Name}  �Դϴ�";
    }
    public void OnClickButtonHobby()
    {
        Txt_Text.text = $"�� ��̴� {Hobby} , {Hobby2} , {Hobby3} , {Hobby4} �Դϴ�";
    }
    public void OnClickButtonGender()
    {
        if(!Gender)
        {
            Txt_Text.text = "����: ����";
        }

        else
        {
            Txt_Text.text = "����: ����";
        }
        
    }
    public void OnClickButtonMBTI()
    {
        Txt_Text.text = MBTI;
    }
    public void OnClickButtonAge()
    {
        Txt_Text.text = "���� ���̴� "+Random.Range(1, 30)+"�� �Դϴ�";
    }
    public void OnClickButtonGame()
    {
        Txt_Text.text = "����  �����ϴ� ������ "+FavoriteGame+ "�Դϴ�";
    }
    public void OnClickButtonGenre()
    {
        Txt_Text.text = $"���� �����ϴ� �帣�� {FavoriteGameGenre} �Դϴ�";
    }
    public void OnClickButtonAnime()
    {
        Txt_Text.text = $"���� �ִ��߿��� {FavoriteAnime}�� �����մϴ�";
    }
    public void OnClickButtonAnimal()
    {
        Txt_Text.text = "����"+FavoriteAnimal+"���������� �ɷ��� ���� ���Ͽ� �⸣�� ���մϴ�";
    }
    public void OnClickButtonChar()
    {
        Txt_Text.text = "����"+FavoriteChar+", "+FavoriteChar1+", " +FavoriteChar2+ ", " +FavoriteChar3+"�� �����մϴ�";
    }
}


