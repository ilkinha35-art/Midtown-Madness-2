using UnityEngine;

public class CarControllerExemplo : MonoBehaviour
{
    public float velocidade = 10f;   // velocidade do carro
    public float rotacao = 100f;     // velocidade de rotação

    void Update()
    {
        // Movimento para frente e para trás
        float move = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(0, 0, move);

        // Rotação esquerda/direita
        float turn = Input.GetAxis("Horizontal") * rotacao * Time.deltaTime;
        transform.Rotate(0, turn, 0);
    }
}
