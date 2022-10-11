using UnityEngine;

public class MemoryCard
{
    public Texture frontTexture;
    private Texture backTexture;
    public int displayNumber;

    public MemoryCard(Texture frontSprite, int displayNumber)
    {
        this.frontTexture = frontSprite;
        this.displayNumber = displayNumber;
        backTexture = SpriteSaver.Instance.texture;
    }
}
