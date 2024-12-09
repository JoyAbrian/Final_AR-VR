using UnityEngine;

public class AnimateYui : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartAllAnimations()
    {
        StartWithWavingAnimation();
    }

    void StartWithWavingAnimation()
    {
        animator.SetInteger("animOtherInt", 2);
        animator.SetInteger("animBaseInt", 0);

        Invoke(nameof(TransitionToConcernAnim), 3.0f);
    }

    void TransitionToConcernAnim()
    {
        animator.SetInteger("animBaseInt", 5);
        animator.SetInteger("animOtherInt", 0);
    }

    void RandomAnimLayerChange()
    {
        int randomLayer = Random.Range(0, 4);
        switch (randomLayer)
        {
            case 0:
                animator.Play("Layer_start", 1, 0.0f);
                break;
            case 1:
                animator.Play("Layer_look_away", 1, 0.0f);
                break;
            case 2:
                animator.Play("Layer_nodding_once", 1, 0.0f);
                break;
            case 3:
                animator.Play("Layer_swinging_body", 1, 0.0f);
                break;
        }
    }

    public void ChangeAnimBase()
    {
        int newBaseInt = Random.Range(1, 9);
        animator.SetInteger("animBaseInt", newBaseInt);

        InvokeRepeating(nameof(RandomAnimLayerChange), 1.0f, 7.0f);
    }
}