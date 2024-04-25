using SupanthaPaul;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
	[SerializeField] private SupanthaPaul.PlayerController _playerController;
    [SerializeField] private SupanthaPaul.PlayerAnimator _playerAnimator;
    [SerializeField] private LocationTransition _locationTransition;
    [SerializeField] private CameraFollow _cameraFollow;

	public override void InstallBindings()
    {
	    Container.Bind<SupanthaPaul.PlayerController>().FromInstance(_playerController).AsSingle().NonLazy();
	    Container.Bind<SupanthaPaul.PlayerAnimator>().FromInstance(_playerAnimator).AsSingle().NonLazy();
		Container.Bind<LocationTransition>().FromInstance(_locationTransition).AsSingle().NonLazy();
		Container.Bind<CameraFollow>().FromInstance(_cameraFollow).AsSingle().NonLazy();
	}
}