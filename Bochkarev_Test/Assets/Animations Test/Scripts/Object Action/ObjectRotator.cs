using UnityEngine;
using DG.Tweening;

public class ObjectRotator : ObjectSimpleAction
{

    [Tooltip("Угол, с которого должен начать поворачиваться")] 
    [SerializeField] private Vector3 rotateStart;
    
    [Tooltip("Угол, до которого должен дойти")] 
    [SerializeField] private Vector3 rotateFinish;

    private void OnValidate()
    {
        transform.rotation = Quaternion.Euler(rotateStart.x, rotateStart.y, rotateStart.z);
    }

    protected override void ObjectAction()
    {
        base.ObjectAction();
        transform.DORotate(rotateFinish, actionTime).SetEase(Ease.InOutSine);
    }
}
