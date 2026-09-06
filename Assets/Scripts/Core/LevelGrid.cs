public class LevelGrid 
{
    public int Width { get; private set; }
    public int Height { get; private set; }

    private TileType[,] tiles;

    public LevelGrid(int width, int height) 
    {
        Width = width;
        Height = height;
        tiles = new TileType[width, height];

        for(int x=0; x < width; x++) 
        {
            for(int y=0; y < height; y++) 
            {
                tiles[x, y] = TileType.Empty;
            }
        }
    }

    public TileType GetTile(int x, int y) 
    {
        if(!IsInBounds(x, y))
            return TileType.Empty;
        
        return tiles[x, y];
    }

    public void SetTile(int x, int y, TileType type) 
    {
        if(!IsInBounds(x, y))
            return;
        
        tiles[x, y] = type;
    }

    public bool IsInBounds(int x, int y)
    {
        return x >= 0 && x < Width && y >= 0 && y < Height;
    }

    public bool IsWalkable(int x, int y) 
    {
        return GetTile(x, y) == TileType.Floor;
    }
}