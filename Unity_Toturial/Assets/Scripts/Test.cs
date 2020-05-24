using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] private Text txt_Money;
    [SerializeField] private InputField inputTxT_Money;

    private int currentMoney;

    public void input()
    {
        currentMoney += int.Parse(inputTxT_Money.text);

        txt_Money.text = currentMoney.ToString();
    }
    public void output()
    {
        currentMoney -= int.Parse(inputTxT_Money.text);

        txt_Money.text = currentMoney.ToString();
    }

}
