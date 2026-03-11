using UnityEngine;

public class CarController : MonoBehaviour
{
    public float velocidade = 15f;
    public float rotacao = 100f;

    void Update()
    {
        float move = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(0, 0, move);

        float turn = Input.GetAxis("Horizontal") * rotacao * Time.deltaTime;
        transform.Rotate(0, turn, 0);
    }
}
