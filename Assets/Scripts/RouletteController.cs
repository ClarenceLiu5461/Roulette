using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float speed = 0; //旋轉速度
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0)) //GetMouseButtonDown為Booling用法指定
        {
            this.speed = 10; //按滑鼠設定旋轉速度
        }
        transform.Rotate(0, 0, this.speed); //調整旋轉速度
        this.speed *= 0.98f; //衰弱係數
     }
}
