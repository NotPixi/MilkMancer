using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public Animator animator;
    public bool isAlive;
    private Vector3 lastPosition;


    public Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponentInChildren<Animator>();
        lastPosition = transform.position;
    }

    public void Revive()
    {
        if (isAlive) return;

        isAlive = true;
        animator.SetBool("IsAlive", true);
    }

    private void Update()
    {
        if (!isAlive) return;

        HandleFollow();
        HandleAnimation();
    }

    void HandleFollow()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            player.position + player.right * 1.5f,
            Time.deltaTime * 2f
        );
    }   

    void HandleAnimation()
    {
        float speed = (transform.position - lastPosition).magnitude / Time.deltaTime;

        if (speed > 0.05f)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        lastPosition = transform.position;
    }
}