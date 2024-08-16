using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Referência aos botões
    public Button Iniciarbutton; // Usando o nome correto
    public Button sairdojogobutton; // Usando o nome correto

    void Start()
    {
        // Adiciona os métodos aos eventos de clique dos botões
        Iniciarbutton.onClick.AddListener(StartGame); // Usando a referência correta
        sairdojogobutton.onClick.AddListener(QuitGame); // Usando a referência correta
    }

    // Método para iniciar o jogo
    void StartGame()
    {
        SceneManager.LoadScene("Escolha"); // Substitua "Escolha" pelo nome exato da cena de escolha
    }

    // Método para sair do jogo
    void QuitGame()
    {
        Application.Quit(); // Fecha o jogo
        Debug.Log("Jogo fechado!"); // Apenas para confirmar que o método é chamado
    }
}
