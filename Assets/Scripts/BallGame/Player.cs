using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField]
    float _acceleration;

    Rigidbody m_rigibBody;
    Camera m_camera;


    void Start()
    {
        m_rigibBody = GetComponent<Rigidbody>();
        m_camera = Camera.main;

        m_rigibBody.maxAngularVelocity = 50;
    }

    void FixedUpdate()
    {
        Vector3 moveVector;

        moveVector = GetMovementVector();
        MovePlayer(moveVector, _acceleration);

    }

    void MovePlayer(Vector3 moveVector, float acceleration)
    {

        Vector3 outVelocity = m_rigibBody.angularVelocity;
        outVelocity += moveVector * acceleration * Time.deltaTime;

        m_rigibBody.angularVelocity = outVelocity;


    }

    Vector3 GetMovementVector()
    {

        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            move += Vector3.right;

        if (Input.GetKey(KeyCode.S))
            move -= Vector3.right;

        if (Input.GetKey(KeyCode.D))
            move -= Vector3.forward;

        if (Input.GetKey(KeyCode.A))
            move += Vector3.forward;

        return move.normalized;

    }
}
