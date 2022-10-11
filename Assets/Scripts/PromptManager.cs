using UnityEngine;
using System;
using TMPro;

namespace PromptSystem
{
    public class PromptManager : MonoBehaviour
    {
        public static Action<Phase> onPhase;
        private TextMeshProUGUI prompt;
        const string rememberPrompt = "Onthoud de plek van de foto";
        const string recallPrompt = "Waar ligt deze foto?";

        public enum Phase
        {
            Remember,
            Recall
        }

        private void UpdatePrompt(Phase phase)
        => prompt.text = phase == Phase.Remember ? rememberPrompt : recallPrompt;

        private void OnEnable()
        => onPhase += UpdatePrompt;

        private void OnDisable()
        => onPhase -= UpdatePrompt;

        void Start()
        {
            prompt = GetComponent<TextMeshProUGUI>();
            prompt.text = rememberPrompt;
        }
    }
}
