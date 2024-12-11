namespace ClothShelfMod;

public class ItemSlotClothShelf : ItemSlot
{
    public override int MaxSlotStackSize => 32;

    public ItemSlotClothShelf(InventoryBase inventory) : base(inventory)
    {
        this.inventory = inventory;
    }

    public override bool CanTakeFrom(ItemSlot slot, EnumMergePriority priority = EnumMergePriority.AutoMerge)
    {
        return slot.ClothShelfCheck() && base.CanTakeFrom(slot, priority);
    }

    public override bool CanHold(ItemSlot slot)
    {
        return slot.ClothShelfCheck() && base.CanHold(slot);
    }
}