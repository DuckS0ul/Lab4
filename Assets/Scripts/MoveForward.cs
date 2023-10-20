using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = -5.0f;

    private void Update()
    {
        // 让小行星朝向玩家移动
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
