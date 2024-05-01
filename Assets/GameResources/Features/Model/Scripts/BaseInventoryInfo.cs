namespace GameInventory.Features.Model
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Базовый класс информации об инвентаре.
    /// </summary>
    public abstract class BaseInventoryInfo<TInventoryItemInfo> : ScriptableObject
    {
        [SerializeField]
        protected List<TInventoryItemInfo> _inventoryItems = new List<TInventoryItemInfo>();

        /// <summary>
        /// Возвращает информацию о предметах в инвентаре.
        /// </summary>
        /// <returns>Массив информации о предметах.</returns>
        public TInventoryItemInfo[] GetInventoryItems() => _inventoryItems.ToArray();
    }
}
