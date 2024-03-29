using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTesting : MonoBehaviour
{
    private CharacterController characterController;
    public Transform camera;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 movement = Vector3.zero;
        Vector3 forward = camera.forward * Input.GetAxis("Vertical");
        Vector3 side = camera.right * Input.GetAxis("Horizontal");
        movement = forward + side;

        characterController.Move(movement);
    }
}
