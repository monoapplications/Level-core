using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleManager : MonoBehaviour
{
    public Text angleText;  // 表示するテキスト

    // Update is called once per frame
    void Update()
    {
        // 加速度を取得
        Vector3 acceleration = Input.acceleration;

        // 傾きの方向
        float gravityX = acceleration.x;
        float gravityY = acceleration.y;
        float gravityZ = acceleration.z;

        // 矢印の方向
        float arrow  = Mathf.Sqrt(acceleration.x * acceleration.x + acceleration.y * acceleration.y);
        float arrowX = acceleration.x / arrow;
        float arrowY = acceleration.y / arrow;

        // 傾き角度：θ：シータ
        float gravity = Mathf.Sqrt(gravityX*gravityX + gravityY*gravityY + gravityZ*gravityZ);
        float theta = Mathf.Acos(-gravityZ/gravity) * Mathf.Rad2Deg;

        // UIに表示
        angleText.text = "矢印X: " + arrowX.ToString("F1") + "\n" +
                         "矢印Y: " + arrowY.ToString("F1") + "\n" +
                         "角度 : " + theta.ToString("F1")  + "度";
    }
}
