using UnityEngine;

public class RevivableSkeleton : MonoBehaviour
{
    private Animator animator;
    private bool isRevived = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Revive()
    {
        if (isRevived) return;

        isRevived = true;
        animator.SetBool("IsAlive", true);

        Debug.Log("Skeleton Revived!");
    }
}