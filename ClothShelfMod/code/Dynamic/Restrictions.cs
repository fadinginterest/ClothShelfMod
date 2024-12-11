namespace ClothShelfMod;

public static class Restrictions {
    #region Shelveable

    public const string Shelvable = "shelvable";

    public static bool ShelvableCheck(this CollectibleObject obj) => obj?.Attributes?[Shelvable].AsBool() == true;
    public static bool ShelvableCheck(this ItemSlot slot) => slot?.Itemstack?.Collectible?.Attributes?[Shelvable].AsBool() == true;

    #endregion 

    #region ClothShelf

    public const string ClothShelfToken = "clothshelfcheck";

    public static bool ClothShelfCheck(this CollectibleObject obj) => obj?.Attributes?[ClothShelfToken].AsBool() == true;
    public static bool ClothShelfCheck(this ItemSlot slot) => slot?.Itemstack?.Collectible?.Attributes?[ClothShelfToken].AsBool() == true;

    public static readonly string[] ClothShelfCodes = new string[] {
        "cloth-*"
    };

    #endregion

}
