using UnityEngine;
using UnityEngine.SceneManagement;

// SUHMIF Simple continue to gameplay script for Fwoggy micro-game

public class TitleScreen : MonoBehaviour
{
    [Header("Title Screen Variables")]
    [SerializeField] int sceneToOpen;

    private void Update()
    {
        // Simply changes from the title screen to gameplay once the X key on a keyboard has been pressed.
        if (Input.GetKey(KeyCode.X))
        {
            SceneManager.LoadScene(sceneToOpen);
        }
    }
}