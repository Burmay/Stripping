using UnityEngine;
using Zenject;

public sealed class PlayerSceneInstaller : MonoInstaller
{
    [SerializeField] private PlayerController _playerControllerPrefab;
    [SerializeField] private Vector3 _playerSpawnPoint;

    private PlayerController _playerControllerInstance;

    public override void InstallBindings()
    {
        _playerControllerInstance = InstantiatePlayer();
        BindPlayer();
        SetReference();
    }

    PlayerController InstantiatePlayer()
    {
        return Container.InstantiatePrefabForComponent<PlayerController>(_playerControllerPrefab, _playerSpawnPoint, Quaternion.identity, null);
    }

    private void BindPlayer()
    {
        Container.Bind<PlayerController>().FromInstance(_playerControllerInstance).AsSingle().NonLazy();
        Container.QueueForInject(_playerControllerInstance);
    }

    private void SetReference()
    {
        PlayerReference.PlayerController = _playerControllerInstance;
        Debug.Log(_playerControllerInstance + "Set reference a complite");
    }

}
