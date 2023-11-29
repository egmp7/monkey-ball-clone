using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] [Range(5.0f,200.0f)] float speed;

    private void Update()
    {
        AnimateCollectable();
    }
    private void OnTriggerEnter(Collider other)
    {
        // destroy if collides with player
        if(other.gameObject.tag == "Player") Destroy(gameObject,0.05f);
    }

    private void AnimateCollectable()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0.0f, Space.Self);
    }
}
