using System;
using System.Collections;
using System.Net.NetworkInformation;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LoadProgress
{
    public class LoadPercent : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textLoad;

        public void Update()
        {
            
            textLoad.text = "Loading - " + (1 * 100).ToString("0") + "%";
        }
    }
}