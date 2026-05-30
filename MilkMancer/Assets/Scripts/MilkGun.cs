using UnityEngine;

public class MilkGun : MonoBehaviour
{
    public GameObject milkProjectile;
    public Transform firePoint;
    public float shootForce = 25f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet =
            Instantiate(milkProjectile,
                        firePoint.position,
                        firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.linearVelocity = firePoint.forward * shootForce;
    }
}