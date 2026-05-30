using UnityEngine;

public class MilkProjectile : MonoBehaviour
{
    public GameObject splashEffect;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(
            splashEffect,
            transform.position,
            Quaternion.identity
        );

        Destroy(gameObject);
    }
}