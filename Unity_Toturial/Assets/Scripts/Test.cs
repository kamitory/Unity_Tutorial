using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private bool isClick;

    private float dotTime = 1f;
    private float currentDotTime = 0f;

    void Start()
    {
        currentDotTime = dotTime; 
    }

    void Update()
    {
        if (isClick)
        {
            currentDotTime -= Time.deltaTime;
            if (currentDotTime <= 0)
            {
                slider.value -= Time.deltaTime;
                if (currentDotTime <= -1f)
                {
                    currentDotTime = dotTime;
                }
            }
        }
    }


    public void Button()
    {
        isClick = true;
    }


}
