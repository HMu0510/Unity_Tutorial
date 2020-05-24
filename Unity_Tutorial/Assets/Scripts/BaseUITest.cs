using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUITest : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;
    [SerializeField] private Sprite sprite;
    private bool isCoolTime = false;

    private float currentTime = 5f;
    private float delayTime = 5f;

    private void Update()
    {
        //컬러 및 알파값등
        //img_name.color = Color.black;
        Color color = img_name.color;
        color.a = 0f;
        img_name.color = color;
        
        if(isCoolTime)
        {
            currentTime -= Time.deltaTime;
            //img_name.fillAmount = currentTime;
            img_name.fillAmount = currentTime / delayTime;
            if(currentTime <=0)
            {
                isCoolTime = false;
                currentTime = delayTime;
                img_name.fillAmount = currentTime;
            }
        }
    }
    public void Change()
    {
        txt_name.text = "변경됨";
        isCoolTime = true;
        //img_name.fillAmount = 0.5f;
    }
}
