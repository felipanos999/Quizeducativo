using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Voltar : MonoBehaviour
{
    // Referência ao botão de voltar
    public Button backButton;

    void Start()
    {
        // Adiciona o método ao evento de clique do botão
        backButton.onClick.AddListener(ReturnToMenu); // Referência ao método correto
    }

    // Método para retornar à cena do menu
    void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu"); // Substitua "Menu" pelo nome exato da cena do menu principal
    }
}
