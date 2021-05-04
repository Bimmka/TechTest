using UnityEngine;
using DG.Tweening;

public class ObjectMover : ObjectSimpleAction
{
    [Tooltip("Точка, до которой должен дойти")] 
    [SerializeField] private Vector3 finishPoint;

    protected override void ObjectAction()
    {
        base.ObjectAction();
        transform.DOMove(finishPoint, actionTime).SetEase(Ease.InOutSine);
    }

}
