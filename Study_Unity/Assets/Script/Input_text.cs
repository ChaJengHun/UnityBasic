using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input_text : MonoBehaviour
{
    public TextMeshProUGUI text_long;    // �ؽ�Ʈ�� �־� �� �� = �ƿ� �ʵ�
    public TextMeshProUGUI Endter_Text;  // �ؽ�Ʈ�� �־� �� �� = �ƿ� �ʵ�
    [SerializeField] TMP_InputField Input_Text; //��𿡼� �ؽ�Ʈ�� �������°� = �Է��ʵ�
   
    public void OnClickButton()
    {
        // �Է� �ʵ忡�� �ؽ�Ʈ�� �����ͼ� �ƿ��ʵ忡 ����
        Endter_Text.text = Input_Text.text;
        text_long.text = Input_Text.text;
    }
}
