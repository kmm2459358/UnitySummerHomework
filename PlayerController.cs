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

        //�W�����v
        if (Input.GetMouseButton(0) && this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jampforce);
        }
    }

    //�E�ړ�
    public void RButtonDown()
    {
        if (this.Player.GetComponent<Transform>().position.x < 9)
        {
            transform.Translate(1, 0, 0);
            transform.localScale = new Vector3(-1f, 1, 1);
        }
    }

    //���ړ�
    public void LButtonDown()
    {
        if (this.Player.GetComponent<Transform>().position.x > -9)
        {
            transform.Translate(-1, 0, 0);
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

 //�_���[�W����
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "paper")
        {
            Debug.Log("��");
            this.director.GetComponent<GameDirector>().PaperDamage();
        }

        if (collision.gameObject.tag == "kyabetu")
        {
            Debug.Log("�L���x�c");
            this.director.GetComponent<GameDirector>().KyabetuDamage();
        }

        if (collision.gameObject.tag == "dog")
        {
            Debug.Log("���I");
            this.director.GetComponent<GameDirector>().DogDamage();
        }
    }
   
}
