using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedX = 5;
    public float speedY = 10;

    public Animator animator;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxis("Vertical");
        speedY = Input.GetAxis("Horizontal");


        animator.SetFloat("speedX", speedY);
        animator.SetFloat("speedY", speedX);

        transform.position = transform.position + new Vector3(speedX, 0, -speedY) * Time.deltaTime;
    }
}
