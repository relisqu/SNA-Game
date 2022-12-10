using System;
using DefaultNamespace;
using UnityEngine;

public class GameChangeState : MonoBehaviour
{
        [SerializeField] private GameObject LoseCanvas;
        [SerializeField] private GameObject HomeCanvas;
        [SerializeField] private GameObject Level;
        [SerializeField] private Transform GarbageTransform;
        public PlayerData PlayerData;
        
        
        
        
        
        
        
        private void Start()
        {

                Level.SetActive(true);
                Health.Instance.Died += LoadScoreScene;
                Level.SetActive(false);
                PlayerData = new PlayerData();
        }

        public void LoadScoreScene()
        {
                Level.SetActive(false);
                HomeCanvas.SetActive(false);
                LoseCanvas.SetActive(true);
                ClearGarbage();
        }

        private void ClearGarbage()
        {
                foreach (Transform garbage in GarbageTransform)
                {
                        Destroy(garbage.gameObject);
                }
                GarbageTransform.gameObject.SetActive(false);
        }

        public void LoadHomeScene()
        {
                
                HomeCanvas.SetActive(true);
                LoseCanvas.SetActive(false);
                Level.SetActive(false);
                ClearGarbage();
        }

        public void LoadGameScene()
        {
                HomeCanvas.SetActive(false);
                LoseCanvas.SetActive(false);
                Level.SetActive(true);
                GarbageTransform.gameObject.SetActive(true);
        }
}