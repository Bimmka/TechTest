using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class ScaleTweener : Tweener
{
    [Header("Размеры UI объекты при анимации")]
    [SerializeField] private Vector3 minSize;
    [SerializeField] private Vector3 maxSize;

    [Header("Скорость анимации")]
    [Tooltip("Треть времени идем до minSize, треть времени - до maxSize, треть - до стандартного scale")]
    [SerializeField] private float animationTime;

    private Vector3 normalSize;

    private void Awake()
    {
        normalSize = transform.localScale;
    }


    private void SetMaxSize()
    {
        transform.DOScale(minSize, animationTime / 3).SetEase(Ease.InOutSine).OnComplete(SetNormalSize);
    }

    private void SetMinSize()
    {
        transform.DOScale(minSize, animationTime / 3).SetEase(Ease.InOutSine).OnComplete(SetMaxSize);
    }

    private void SetNormalSize()
    {
        transform.DOScale(normalSize, animationTime / 3).SetEase(Ease.InOutSine);
    }

    protected override void Action()
    {
        SetMinSize();
    }
}
