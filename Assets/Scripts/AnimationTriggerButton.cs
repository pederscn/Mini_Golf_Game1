using UnityEngine;

public class AnimationTriggerButton : MonoBehaviour
{
    public Animator animator;  // Reference to the Animator component

    private void Start()
    {
        // Get the Animator component from the object you want to animate
        animator = GetComponent<Animator>();
    }

    public void OnButtonClicked()
    {
        if (animator != null)
        {
            // Trigger the animation
            animator.SetTrigger("PuttingAnimationTrigger"); // Change "PuttAnimationTrigger" to the actual trigger name in your Animator
        }
    }
}
