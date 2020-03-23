using UnityEngine;

public class Quit : MonoBehaviour
{
    void Update()
    {
        // quitte l'application quand on appuie sur ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
