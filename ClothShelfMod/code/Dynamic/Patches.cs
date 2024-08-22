namespace ClothShelfMod;

public static class Patches {
    private static readonly Transformations Transformations = new();

    public static void PatchClothShelf(CollectibleObject obj) {
        if (WildcardUtil.Match(ClothShelfCodes, obj.Code.Path.ToString()))
        {
            obj.EnsureAttributesNotNull();
            obj.Attributes.Token[ClothShelf] = JToken.FromObject(true);

            ModelTransform transformation = obj.GetTransformation(Transformations.ClothShelfTransformations);
            if (transformation != null)
            {
                obj.Attributes.Token[onClothShelfTransform] = JToken.FromObject(transformation);
            }
        }
    }

}