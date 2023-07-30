using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private Transform targetTransform;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float camSpeed;

    void Awake()
    {
        targetTransform = PlayerReference.PlayerController.transform;
    }

    void LateUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (targetTransform == null) return;
        Vector3 nextPos = Vector3.Lerp(transform.position, targetTransform.position + offset, Time.deltaTime * camSpeed);
        transform.position = nextPos;
    }

}
