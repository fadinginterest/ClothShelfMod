using static ClothShelfMod.Patches;

[assembly: ModInfo(name: "Cloth Shelves", modID: "clothshelf")]

namespace ClothShelfMod;

public class Core : ModSystem {
    public override void Start(ICoreAPI api) {
        base.Start(api);

        api.RegisterBlockClass("ClothShelfMod.BlockClothShelf", typeof(BlockClothShelf));
        api.RegisterBlockEntityClass("ClothShelfMod.BlockEntityClothShelf", typeof(BlockEntityClothShelf));
        
    }

    public override void AssetsFinalize(ICoreAPI api) {
        base.AssetsFinalize(api);

        foreach (CollectibleObject obj in api.World.Collectibles) {
            PatchClothShelf(obj);
            
        }
    }
}
