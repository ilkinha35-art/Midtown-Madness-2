using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public Material[] materiaisDisponiveis;
    private Renderer carroRenderer;
    private int indiceAtual = 0;

    void Start()
    {
        carroRenderer = GetComponent<Renderer>();
        carroRenderer.material = materiaisDisponiveis[indiceAtual];
    }

    void Update()
    {
        // Troca textura ao apertar a tecla T
        if (Input.GetKeyDown(KeyCode.T))
        {
            indiceAtual = (indiceAtual + 1) % materiaisDisponiveis.Length;
            carroRenderer.material = materiaisDisponiveis[indiceAtual];
        }
    }
}
