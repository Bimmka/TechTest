using DG.Tweening;
using UnityEngine;

public class ObjectScaler : ObjectSimpleAction
{
    [Tooltip("Начальное значение scale")]
    [SerializeField] private Vector3 startScale;

    [Tooltip("Конечное значение scale")] 
    [SerializeField] private Vector3 finishScale;

    private void OnValidate()
    {
        transform.localScale = startScale;
    }

    protected override void ObjectAction()
    {
        transform.DOScale(finishScale, actionTime).SetEase(Ease.InOutSine);
    }
}
