using System;
using UnityEngine;
using Zenject;

public class MovementHandler: IDisposable
{
    IInput _input;
    float _speed;

    public MovementHandler(IInput input)
    {
        _input = input;
        _input.Direcion += Move;
        Parameterize();
    }

    void Parameterize()
    {
        _speed = 100f;
    }

    public void UpdateInput()
    {
        _input.Update();
    }

    void Move(Vector2 directoin)
    {
        Debug.Log(directoin * _speed * Time.deltaTime);
        PlayerReference.PlayerController.transform.Translate(directoin * _speed * Time.deltaTime);
    }

    public void Dispose()
    {
        _input.Direcion -= Move;
    }

}
