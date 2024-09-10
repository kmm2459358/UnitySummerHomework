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

    //�V�����̃_���[�W
    public void PaperDamage()
    {
        this.HP -= 5;
        Debug.Log("hp -5");
    }

    //�L���x�c�̃_���[�W
    public void KyabetuDamage()
    {
        this.HP -= 10;
        Debug.Log("hp -10");
    }

    //���̃_���[�W
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
        //HP�Ǘ�
        this.HpGauge.GetComponent<Image>().fillAmount = HP / MaxHp;

        //���Ԍ��炵
        this.time -= Time.deltaTime;

        Debug.Log(time);
    }
}
