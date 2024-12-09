using UnityEngine;
using R3;

/// <summary>
/// Titleä«óùópÇÃScript
/// </summary>
public class Title : MonoBehaviour
{
    /// <summary>
    /// titleópÇÃView
    /// </summary>
    [SerializeField] private TitleView _view = default!;

    /// <summary>
    /// 
    /// </summary>
    private Reticle _reticle = default!;

    /// <inheritdoc/>
    private void Start()
    {
        _reticle = Reticle.GetInstance();

        _reticle.ExampleMethod();

        _reticle.MovedMousePosReactiveProperty.Skip(1).Subscribe(pos =>
        {
            _view.UpdateReticleObjectPostion(pos);
        }).AddTo(this);
    }
}
