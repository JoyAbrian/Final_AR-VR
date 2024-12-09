using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 50f;
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
    }

    public void RotateObject()
    {
        isRotating = !isRotating;
    }
}
