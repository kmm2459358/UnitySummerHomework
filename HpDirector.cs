using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpDirector : MonoBehaviour
{
    GameObject HpGauge;
    float MaxHp = 100.0f;
    public float Hp = 100.0f;

    void Start()
    {
        this.HpGauge = GameObject.Find("hpGauge");
    }

    void HpDecrease()
    {
        this.HpGauge.GetComponent<Image>().fillAmount = Hp / MaxHp;
        //Image.fillAmount = 0.5f;
    }
}
