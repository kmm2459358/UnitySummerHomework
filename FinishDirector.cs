using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishDirector : MonoBehaviour
{
    GameObject obj;
    public GameDirector director;

    void Start()
    {
        this.obj = GameObject.Find("GameDirector");
        this.director = obj.GetComponent<GameDirector>();
    }

    void Update()
    {
        //HP�O�ŃQ�[���I�[�o�[
        float Hp = this.director.HP;
        if (Hp <= 0)
        {
            SceneManager.LoadScene("GameoverScene");
        }

        //���ԂO�ŃQ�[���N���A
        float Time = this.director.time;
        if (Time <= 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
