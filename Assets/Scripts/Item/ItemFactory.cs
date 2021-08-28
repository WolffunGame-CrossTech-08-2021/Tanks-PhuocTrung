using UnityEngine;

public class ItemFactory
{
    public static Item GetItem(ItemEnum nameEnum)
    {
        switch (nameEnum)
        {
            case ItemEnum.Health:
                return new HealthItem();
            case ItemEnum.Boots:
                return new BootsItem();
            case ItemEnum.PoisonJar:
                return new PoisonJarItem();
            case ItemEnum.Rocket:
                return new RocketItem();
            default:
                Debug.LogError("Item name incorrect @@ !");
                return null;
        }
    }
}
