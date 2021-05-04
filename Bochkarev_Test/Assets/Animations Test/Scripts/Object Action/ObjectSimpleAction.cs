using UnityEngine;

public class ObjectSimpleAction : MonoBehaviour
{
    [Tooltip("Время, за которое должно произойти действие")]
    [SerializeField] protected float actionTime = 1f;
    private void Start()
    {
        ObjectAction();
    }

    protected virtual void ObjectAction()
    {
        
    }
}
