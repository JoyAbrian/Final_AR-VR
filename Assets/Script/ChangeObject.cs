using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    private Transform[] children;
    private int currentChildIndex = 0;

    void Start()
    {
        children = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            children[i] = transform.GetChild(i);
            children[i].gameObject.SetActive(false);
        }

        if (children.Length > 0)
        {
            children[currentChildIndex].gameObject.SetActive(true);
        }
    }

    public void SwitchActiveChild()
    {
        if (children.Length > 0)
        {
            children[currentChildIndex].gameObject.SetActive(false);
        }

        currentChildIndex = (currentChildIndex + 1) % children.Length;
        children[currentChildIndex].gameObject.SetActive(true);
    }
}