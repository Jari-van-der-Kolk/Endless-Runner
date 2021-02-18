using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] float speed;
    // increases the speed. so the camera moves faster over time.
    [SerializeField] float overTimeSpeedAdder;
    private float velocity;
    [SerializeField] float cameraYOffset, cameraZOffset;

    private GameObject Player;
    private void Start()
    {
        velocity = transform.position.x;
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
       
        speed += Time.deltaTime * overTimeSpeedAdder;
        speed = Mathf.Clamp(speed, 0, maxSpeed);
        velocity += Time.deltaTime * speed;
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(velocity, cameraYOffset, cameraZOffset), 0.1f);
    }
}
