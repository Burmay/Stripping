using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerReference
{
    private static PlayerController playerController;
    public static PlayerController PlayerController
    {
        get => playerController;
        set => playerController ??= value;
    }
}
