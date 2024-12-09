using UnityEngine;
using Zenject;

public class GameObjectSample : IInitializable
{
    [Inject] Greeter greeter;

    public void Initialize()
    {
        greeter.Greet();
    }
}
