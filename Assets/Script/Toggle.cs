using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject canvas;

    public void ActivateCanvas()
    {
        canvas.SetActive(true);
    }

    public void DeactivateCanvas()
    {
        canvas.SetActive(false);
    }
}
