using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input_text : MonoBehaviour
{
    public TextMeshProUGUI text_long;    // 텍스트를 넣어 줄 곳 = 아웃 필드
    public TextMeshProUGUI Endter_Text;  // 텍스트를 넣어 줄 곳 = 아우 필드
    [SerializeField] TMP_InputField Input_Text; //어디에서 텍스트를 가져오는가 = 입력필드
   
    public void OnClickButton()
    {
        // 입력 필드에서 텍스트를 가져와서 아웃필드에 설정
        Endter_Text.text = Input_Text.text;
        text_long.text = Input_Text.text;
    }
}
