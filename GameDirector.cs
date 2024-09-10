using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject HpGauge;
    float MaxHp = 100;
    public float HP;
    public float time;

    //新聞紙のダメージ
    public void PaperDamage()
    {
        this.HP -= 5;
        Debug.Log("hp -5");
    }

    //キャベツのダメージ
    public void KyabetuDamage()
    {
        this.HP -= 10;
        Debug.Log("hp -10");
    }

    //犬のダメージ
    public void DogDamage()
    {
        this.HP -= 20;
        Debug.Log("hp -20");
    }

    void Start()
    {
        this.HpGauge = GameObject.Find("hpGauge");
    }

    void Update()
    {
        //HP管理
        this.HpGauge.GetComponent<Image>().fillAmount = HP / MaxHp;

        //時間減らし
        this.time -= Time.deltaTime;

        Debug.Log(time);
    }
}
