using UnityEngine;

public class MilkProjectile : MonoBehaviour
{
    public GameObject splashEffect;

    private void OnCollisionEnter(Collision collision)
    {
        // Spawn splash
        Instantiate(
            splashEffect,
            collision.contacts[0].point,
            Quaternion.identity
        );

        // Check if we hit a revivable skeleton
        RevivableSkeleton skeleton =
            collision.gameObject.GetComponent<RevivableSkeleton>();

        if (skeleton != null)
        {
            skeleton.Revive();
        }

        // Destroy milk projectile
        Destroy(gameObject);
    }
}