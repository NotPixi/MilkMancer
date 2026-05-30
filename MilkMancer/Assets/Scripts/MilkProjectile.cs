using UnityEngine;

public class MilkProjectile : MonoBehaviour
{
    public GameObject splashEffect;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(
            splashEffect,
            collision.contacts[0].point,
            Quaternion.identity
        );

        Skeleton skeleton =
            collision.collider.GetComponentInParent<Skeleton>();

        if (skeleton != null)
        {
            skeleton.Revive();
        }

        Destroy(gameObject);
    }
}