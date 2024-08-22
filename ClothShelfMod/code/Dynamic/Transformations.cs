namespace ClothShelfMod;

public class Transformations {
    public const string onDisplayTransform = "onDisplayTransform"; // Vanilla shelf
    public const string onClothShelfTransform = "onClothShelfTransform";

    #region ClothShelf

    public Dictionary<string, ModelTransform> ClothShelfTransformations = new() {
        //{ "*cloth-*", new ModelTransform() {
        //    Origin = new() { X = 0.5f, Y = 0f, Z = 0.5f },
        //    Scale = 0.8f
        //}}
    };

    #endregion


}