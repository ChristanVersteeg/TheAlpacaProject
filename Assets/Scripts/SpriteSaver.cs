using UnityEngine;

[CreateAssetMenu(fileName = nameof(SpriteSaver), menuName = "ScriptableObjects/" + nameof(SpriteSaver))]
public class SpriteSaver : ScriptableObject
{
    public Texture texture;
    public static SpriteSaver Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        Instance = this;
    }
}
