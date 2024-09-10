using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurretGenerator : MonoBehaviour
{
    public GameObject paperPrefab;
    public GameObject cabbagePrefab;
    public GameObject dogPrefab;
    GameObject go;
    float span = 1.5f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > span)
        {
            this.delta = 0;
            int burret = Random.Range(1, 4);
            switch (burret)
            {
                case 1: go = Instantiate(paperPrefab);
                    burretStart(); 
                    break;
                case 2: go = Instantiate(cabbagePrefab);
                    burretStart();
                    break;
                case 3: go = Instantiate(dogPrefab);
                    burretStart();
                    break;
            }
        }
    }

    void burretStart()
    {
        float px = Random.Range(-19.5f, -15.0f);
        float py = Random.Range(0, 4.3f);
        go.transform.position = new Vector3(px, py, 0);
    }
}
