using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jampforce = 600.0f;
    public bool isGround;
    GameObject director;
    GameObject HpGauge;
    GameObject Player;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.director = GameObject.Find("GameDirector");
        this.HpGauge = GameObject.Find("hpGauge");
        this.Player = GameObject.Find("kaaiyuki_1");
    }

    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        //ジャンプ
        if (Input.GetMouseButton(0) && this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jampforce);
        }
    }

    //右移動
    public void RButtonDown()
    {
        if (this.Player.GetComponent<Transform>().position.x < 9)
        {
            transform.Translate(1, 0, 0);
            transform.localScale = new Vector3(-1f, 1, 1);
        }
    }

    //左移動
    public void LButtonDown()
    {
        if (this.Player.GetComponent<Transform>().position.x > -9)
        {
            transform.Translate(-1, 0, 0);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

 //ダメージ判定
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "paper")
        {
            Debug.Log("紙");
            this.director.GetComponent<GameDirector>().PaperDamage();
        }

        if (collision.gameObject.tag == "kyabetu")
        {
            Debug.Log("キャベツ");
            this.director.GetComponent<GameDirector>().KyabetuDamage();
        }

        if (collision.gameObject.tag == "dog")
        {
            Debug.Log("犬！");
            this.director.GetComponent<GameDirector>().DogDamage();
        }
    }
   
}
