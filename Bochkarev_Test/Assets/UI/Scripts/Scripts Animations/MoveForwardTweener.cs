using UnityEngine;
using DG.Tweening;
using System;

public class MoveForwardTweener : Tweener
{
    [Header("Точка, в которую должен прийти объект")]
    [SerializeField] private RectTransform finishPosition;

    [Header("Время анимации")]
    [SerializeField] private float animationTime;

    public static Action OnMoveEnd;

    private void EndMove()
    {
        OnMoveEnd?.Invoke();
    }

    protected override void Action()
    {
        transform.DOMove(finishPosition.localPosition, animationTime).SetEase(Ease.InOutSine).OnComplete(EndMove);
    }
}
