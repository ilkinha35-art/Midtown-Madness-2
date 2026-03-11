using UnityEngine;
using UnityEngine.SceneManagement;

public class CitySelector : MonoBehaviour
{
    public void CarregarLondres()
    {
        SceneManager.LoadScene("Londres");
    }

    public void CarregarSaoFrancisco()
    {
        SceneManager.LoadScene("SaoFrancisco");
    }

    public void CarregarMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}
