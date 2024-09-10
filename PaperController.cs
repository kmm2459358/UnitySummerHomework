using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        Application.targetFrameRate = 60;
        this.player = GameObject.Find("kaaiyuki_1");
    }

    void Update()
    {
        //ˆÚ“®
        transform.Translate(0.25f, 0, 0);

        //‰æ–ÊŠO‚Å”jŠü
        if (transform.position.x > 12.0f)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}
