using UnityEngine;

// SUHMIF Simple move forward script for Fwoggy micro-game

public class PrefabBehaviour : MonoBehaviour
{
    [Header("Prefab Behaviour Variables")]
    [SerializeField] int movementSpeed;

    private void Update()
    {
        // Move's the prefab right each frame, depending on the rotation of the spawner so local not world 
        transform.position += transform.right * movementSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //  Prevents duplicates from slowing performance due to amount in scene, by removing them
        if (collision.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}