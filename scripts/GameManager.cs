using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text cronometroTexto;
    private float tempo;

    void Update()
    {
        tempo += Time.deltaTime;
        cronometroTexto.text = "Tempo: " + tempo.ToString("F1") + "s";
    }
}
