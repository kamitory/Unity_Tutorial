using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image image_name;
    [SerializeField] private Sprite sprite;

    private bool isCoolTime = false;

    private float currentTime = 5f;
    private float delayTime = 5f;
    //[SerializeField] private UnityEngine.UI.Text txt_name;
    
    void Update()
    {
        //image_name.sprite =
        //image_name.color = Color.red; 

        if (isCoolTime)
        {
            currentTime -= Time.deltaTime;
            image_name.fillAmount = currentTime / delayTime;

            if(currentTime <= 0)
            {
                isCoolTime = false;
                currentTime = delayTime;
                image_name.fillAmount = currentTime;
            }
        }
    
    }


    public void Change()
    {
        txt_name.text = "변경됨";
        isCoolTime = true;
        //image_name.fillAmount = 0.5f;
    }

    //void Start()
    //{
    //  
    //}

}
