using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tweener : MonoBehaviour, ITweener
{
    public void ActivateTweener()
    {
        Action();
    }

    protected abstract void Action();

}
