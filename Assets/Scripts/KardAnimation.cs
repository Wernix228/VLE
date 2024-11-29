using UnityEngine;

public class KardAnimation : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    bool active = false;

    public void onPress()
    {
        active = !active;
        animator.enabled = true;
        animator.SetBool("Active", active);
    }
}
