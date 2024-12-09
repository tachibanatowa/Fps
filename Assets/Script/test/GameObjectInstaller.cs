using UnityEngine;
using Zenject;

public class GameObjectInstaller : MonoInstaller<GameObjectInstaller>
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<GameObjectSample>().AsSingle();
    }
}

