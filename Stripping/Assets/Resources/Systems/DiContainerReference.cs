using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public static class DiContainerReference
{
    private static DiContainer container;

    public static DiContainer Container
    {
        get => container;

        set => container ??= value;
    }
}