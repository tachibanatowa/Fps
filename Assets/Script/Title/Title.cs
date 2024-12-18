using UnityEngine;
using R3;

/// <summary>
/// Title管理用のScript
/// </summary>
public class Title : MonoBehaviour
{
    /// <summary>
    /// title用のView
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
