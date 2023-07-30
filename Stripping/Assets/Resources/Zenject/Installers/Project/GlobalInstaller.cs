using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Zenject;

public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("GlobalInstaller work");

        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            Container.Bind<IInput>().To<MobileInput>().FromNew().AsSingle();
        }
        else
        {
            Container.Bind<IInput>().To<ComputerInput>().FromNew().AsSingle();
        }

        Debug.Log(SystemInfo.deviceType);
    }
}
