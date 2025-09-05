using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColorSystem : MonoBehaviour
{
    private Renderer playerRenderer;

    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //If player hits a ColorChanger obstacle to take its color
        if (other.CompareTag("ColorChanger"))
        {
            Color newColor = other.GetComponent<Renderer>().material.color;
            playerRenderer.material.color = newColor;

            //Optional: Destroy the color changer after use
            Destroy(other.gameObject);
        }

        //If player hits a MatchColor cube to check if colors match
        if (other.CompareTag("MatchColor"))
        {
            Color cubeColor = other.GetComponent<Renderer>().material.color;

            if (ColorsAreEqual(playerRenderer.material.color, cubeColor))
            {
                //Correct destroy cube
                Destroy(other.gameObject);
            }
            else
            {
                //Wrong restart scene
                SceneManager.LoadScene("Play");
            }
        }
    }

    //Helper to compare colors
    private bool ColorsAreEqual(Color a, Color b, float tolerance = 0.01f)
    {
        return Mathf.Abs(a.r - b.r) < tolerance &&
               Mathf.Abs(a.g - b.g) < tolerance &&
               Mathf.Abs(a.b - b.b) < tolerance;
    }
}
