using UnityEngine;

public class KardAnimation : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    bool active = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onPress()
    {
        active = !active;
        animator.enabled = true;
        animator.SetBool("Active", active);
    }
}
