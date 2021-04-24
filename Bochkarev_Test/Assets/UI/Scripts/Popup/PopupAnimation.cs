using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PopupAnimation : MonoBehaviour
{
    [Tooltip("Кнопка ОК")]
    [SerializeField] private Button okButton;

    [Tooltip("Объекты с твинерами, которые нужно выполнить при нажатии на кнопку")]
    [SerializeField] private GameObject objectsWithTweeners;

    private ITweener[] tweeners;

    private void Awake()
    {
        okButton.onClick.AddListener(StartAnimation);

        tweeners = objectsWithTweeners.GetComponents<ITweener>().ToArray();

        MoveForwardTweener.OnMoveEnd += DisablePopup;
    }

    private void OnDestroy()
    {
        okButton.onClick.RemoveListener(StartAnimation);

        MoveForwardTweener.OnMoveEnd -= DisablePopup;
    }

    private void StartAnimation()
    {
        for (int i = 0; i < tweeners.Length; i++)
        {
            tweeners[i].ActivateTweener();
        }
    }

    private void DisablePopup()
    {
        if (gameObject.activeSelf)
            gameObject.SetActive(false);
    }




}
