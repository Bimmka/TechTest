using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class EnhancedButton : MonoBehaviour
{
    private ITweener[] tweeners;

    private Button currentButton;

    private void Awake()
    {
        currentButton = GetComponent<Button>();
        currentButton.onClick.AddListener(ActivateTweener);

        tweeners = GetComponentsInChildren<ITweener>(true).ToArray();
    }

    private void OnDestroy()
    {
        currentButton.onClick.RemoveListener(ActivateTweener);
    }

    private void ActivateTweener()
    {
        for (int i = 0; i < tweeners.Length; i++)
        {
            tweeners[i].ActivateTweener();
        }
    }
}
