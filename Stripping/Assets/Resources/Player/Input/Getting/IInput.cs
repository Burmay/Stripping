using System;
using UnityEngine;

public interface IInput
{
    public event Action<Vector2> Direcion;
    public void Update();
}
