using UnityEngine;
using UnityEngine.UI;
using R3;

/// <summary>
/// title—p‚ÌView
/// </summary>
public class TitleView : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] private GameObject _reticleObject = default!;


    /// <summary>
    /// 
    /// </summary>
    /// <param name="postion"></param>
    public void UpdateReticleObjectPostion(Vector3 postion)
    {
        _reticleObject.transform.position = postion;
    }
}
