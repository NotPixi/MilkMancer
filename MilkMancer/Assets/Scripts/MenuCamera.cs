using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    public float speed = 0.5f;
    public float amount = 0.2f;

    Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position = startPos +
            new Vector3(
                Mathf.Sin(Time.time * speed) * amount,
                Mathf.Cos(Time.time * speed) * amount,
                0);
    }
}