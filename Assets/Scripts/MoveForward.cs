using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = -5.0f;

    private void Update()
    {
        // ��С���ǳ�������ƶ�
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
