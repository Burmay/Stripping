using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    MovementHandler _movementHandler;

    [Inject]
    public void Constructor(MovementHandler movementHandler)
    {
        _movementHandler = movementHandler;
    }

    public Transform GetTransform() => transform;

    private void Update()
    {
        _movementHandler.UpdateInput();

    }

}
