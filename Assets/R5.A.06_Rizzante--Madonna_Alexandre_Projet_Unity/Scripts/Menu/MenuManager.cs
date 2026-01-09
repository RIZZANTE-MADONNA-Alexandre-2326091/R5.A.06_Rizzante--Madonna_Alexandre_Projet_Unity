using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class MenuManager: MonoBehaviour
{
    private MainStage MainStage;
    private SceneSetup Setup;

    public void Start()
    {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        string scenePath = "Assets/Scenes/";
        if (MainStage.assetPath == "Assets/Scenes/VoidScene.unity")
        {
            scenePath = "Assets/Scenes/BaseScene.unity";
        }
        else
        {
            scenePath = "Assets/Scenes/VoidScene.unity";
        }
        EditorSceneManager.OpenScene(scenePath);
        yield return scenePath;
    }
}
