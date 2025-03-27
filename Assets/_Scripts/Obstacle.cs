using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float SpeedModifier;

    void Update()
    {
        transform.Translate(Vector3.left * GameManager.Instance.Speed * SpeedModifier);

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
