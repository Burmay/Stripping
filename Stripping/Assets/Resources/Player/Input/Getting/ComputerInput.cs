using System;
using UnityEngine;

public class ComputerInput : IInput
{
    public event Action<Vector2> Direcion;

    Vector2 _direction;
    const string _vertical = "Vertical";
    const string _horizontal = "Horizontal";
    

    public void Update()
    {
        _direction.y = Input.GetAxis(_vertical);
        _direction.x = Input.GetAxis(_horizontal);

        if(_direction != Vector2.zero)
        {
            Direcion.Invoke(_direction);
        }
    }
}
