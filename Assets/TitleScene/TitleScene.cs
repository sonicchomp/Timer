﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    //音楽流したい
  }

  public void OnStartBotton()
  {
    Debug.Log("Go to Setting Scene");
    SceneManager.LoadScene("SettingScene");
  }
}
