using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    public string triggerName = "StartAnimation";
    public string boolName = "IsAnimating";


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void ActivateTrigger()
    {
        animator.SetTrigger(triggerName);
    }

    public void ToggleBool() {
        bool currentState = animator.GetBool(boolName);
        animator.SetBool(boolName, !currentState);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
