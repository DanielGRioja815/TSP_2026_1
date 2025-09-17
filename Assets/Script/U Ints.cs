using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class UInits : MonoBehaviour {
    //Variables de Control
    static int currentIndex = 0;

    //Variables de Objetos
    [SerializeField]
    public List<string> message;

    [SerializeField]
    public TextMeshProUGUI texts;

    //Objeto persistente
    public GameObject player;

    //Control de escenas
    public string sceneName;
    public int sceneIndex;

    private void Awake() {
        DontDestroyOnLoad(player);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        currentIndex = 0;
    }

    public void CycleText() {
        currentIndex = (currentIndex + 1) % message.Count;
        UpddateText();
    }

    public void UpddateText() {
        if (message.Count > 0 && texts != null) {
            texts.text = message[currentIndex];
        }
    }

    // Update is called once per frame
    void Update() {

    }

    public void ChangeSceneByIndex(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);

    }
    
    public void ChangeSceneByName(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene() {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void ExitGame() {
        Application.Quit();
    }
}