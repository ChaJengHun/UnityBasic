using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Text_Scp : MonoBehaviour
{
    private string Name = "차정훈";
    private bool Gender = false;
    private string Hobby = "게임";
    private string Hobby2 = "만화 감상";
    private string Hobby3 = "애니 감상";
    private string Hobby4 = "프라모델";
    private string MBTI = "INTJ";
    private string FavoriteChar = "호두";
    private string FavoriteChar1 = "하쿠레이 레이무";
    private string FavoriteChar2 = "하츠네 미쿠";
    private string FavoriteChar3 = "타타라 코가사";
    private string FavoriteGameGenre = "로그라이크";
    private string FavoriteGame = "Master Duel";
    private string FavoriteAnime = "은혼";
    private string FavoriteAnimal = "Red eyed armored skink";

    public TextMeshProUGUI Txt_Text;
    
    public void OnClickButtonName()
    {
        
        Txt_Text.text = $"내이름은 {Name}  입니다";
    }
    public void OnClickButtonHobby()
    {
        Txt_Text.text = $"내 취미는 {Hobby} , {Hobby2} , {Hobby3} , {Hobby4} 입니다";
    }
    public void OnClickButtonGender()
    {
        if(!Gender)
        {
            Txt_Text.text = "성별: 남성";
        }

        else
        {
            Txt_Text.text = "성별: 여성";
        }
        
    }
    public void OnClickButtonMBTI()
    {
        Txt_Text.text = MBTI;
    }
    public void OnClickButtonAge()
    {
        Txt_Text.text = "저의 나이는 "+Random.Range(1, 30)+"살 입니다";
    }
    public void OnClickButtonGame()
    {
        Txt_Text.text = "내가  좋아하는 게임은 "+FavoriteGame+ "입니다";
    }
    public void OnClickButtonGenre()
    {
        Txt_Text.text = $"내가 좋아하는 장르는 {FavoriteGameGenre} 입니다";
    }
    public void OnClickButtonAnime()
    {
        Txt_Text.text = $"나는 애니중에서 {FavoriteAnime}을 좋아합니다";
    }
    public void OnClickButtonAnimal()
    {
        Txt_Text.text = "나는"+FavoriteAnimal+"좋아하지만 능력이 되지 못하여 기르지 못합니다";
    }
    public void OnClickButtonChar()
    {
        Txt_Text.text = "나는"+FavoriteChar+", "+FavoriteChar1+", " +FavoriteChar2+ ", " +FavoriteChar3+"를 좋아합니다";
    }
}


