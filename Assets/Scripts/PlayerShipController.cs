using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShipController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5.0f;
    public float tiltAmount = 15.0f;
    private Vector2 currentInput;

    //public float xBoundary = 1;
    //public float yBoundary = 3.0f;

    public GameObject boltPrefab;
    public Transform shotSpawn;
    private float nextFire;
    public float fireRate = 0.5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue value)
    {
        currentInput = value.Get<Vector2>();
    }

    public void OnFire()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(boltPrefab, shotSpawn.position, shotSpawn.rotation);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(currentInput.x, 2.0f, currentInput.y) * speed;

        float clampedX = Mathf.Clamp(rb.position.x, -5, 5);
        float clampedZ = Mathf.Clamp(rb.position.z, 0, 3);
        rb.position = new Vector3(clampedX, 4.0f, clampedZ);

        float tilt = currentInput.x * -tiltAmount;
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, tilt);
    }
}