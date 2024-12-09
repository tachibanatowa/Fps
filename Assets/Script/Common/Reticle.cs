using UnityEngine;
using UnityEngine.EventSystems;
using R3;

/// <summary>
/// 
/// </summary>
public sealed class Reticle : MonoBehaviour, IPointerMoveHandler
{
    /// <summary>
    /// 
    /// </summary>
    private static Reticle _reticle = null;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static Reticle GetInstance()
    {
        return _reticle;
    }

    private void Awake()
    {

        if (_reticle == null)
        {
            _reticle = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // �d������C���X�^���X��j��
        }
    }

    public void ExampleMethod()
    {
        Debug.Log("SimpleSingleton�̃��\�b�h���Ă΂�܂���");
    }

    /// <summary>
    /// 
    /// </summary>
    public Vector3 ReticlePos { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public ReadOnlyReactiveProperty<Vector3> MovedMousePosReactiveProperty => _reactiveProperty;

    /// <summary>
    /// 
    /// </summary>
    private ReactiveProperty<Vector3> _reactiveProperty = new ReactiveProperty<Vector3>();


    // �}�E�X�����������̏���
    public void OnPointerMove(PointerEventData eventData)
    {
        Debug.Log($"�}�E�X�ړ��ʒu: {eventData.position}");

        var worldPos = Camera.main.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, 10f));
        //���[���h���W��RetoclePos�ɐݒ�
        ReticlePos = worldPos;

        _reactiveProperty.Value = worldPos;
    }

}
