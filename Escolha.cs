using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Escolha : MonoBehaviour{
// Referências aos botões
    public Button portuguesButton;
    public Button inglesButton;
    public Button matematicaButton;
    public Button historiaButton;
    public Button geografiaButton;
    public Button fisicaButton;
    public Button quimicaButton;
    public Button biologiaButton;
 
    void Start()
    {
        // Adiciona os métodos aos eventos de clique dos botões
        portuguesButton.onClick.AddListener(() => LoadGame("Português"));
        inglesButton.onClick.AddListener(() => LoadGame("Inglês"));
        matematicaButton.onClick.AddListener(() => LoadGame("Matemática"));
        historiaButton.onClick.AddListener(() => LoadGame("História"));
        geografiaButton.onClick.AddListener(() => LoadGame("Geografia"));
        fisicaButton.onClick.AddListener(() => LoadGame("Física"));
        quimicaButton.onClick.AddListener(() => LoadGame("Química"));
        biologiaButton.onClick.AddListener(() => LoadGame("Biologia"));
    }
 
    // Método para carregar a cena do jogo
    void LoadGame(string materia)
    {
        // Aqui você pode usar a variável "materia" para passar informações sobre a escolha
        // ou configurar a cena do jogo de acordo com a escolha feita.
        SceneManager.LoadScene("Game"); // Substitua "Game" pelo nome exato da cena do jogo
    }
}
