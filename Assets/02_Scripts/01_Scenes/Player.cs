using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        var input = new Vector2(
            (Input.GetKey(KeyCode.D) ? 1f : 0f) - (Input.GetKey(KeyCode.A) ? 1f : 0f),
            (Input.GetKey(KeyCode.W) ? 1f : 0f) - (Input.GetKey(KeyCode.S) ? 1f : 0f)
        );

        if (input.sqrMagnitude > 1f)
        {
            input.Normalize();
        }

        var delta = (Vector3)(input * moveSpeed * Time.deltaTime);
        transform.position += delta;
    }
}
