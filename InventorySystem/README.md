# Inventory System

Система инвентаря на основе `ScriptableObject`: предметы описываются как данные, а не как отдельные классы, что упрощает добавление нового контента без кода.

## Как использовать

1. Создать предмет через `Assets → Create → Inventory → Item`.
2. Добавить `InventoryManager` на сцену.
3. Управлять инвентарём: `AddItem(item, amount)`, `RemoveItem(item, amount)`, `GetItemCount(item)`.
4. Подписаться на `OnInventoryChanged` для обновления UI.

## Паттерны

- Data-driven дизайн через ScriptableObject
- Singleton для доступа к менеджеру
- Событие (event) для оповещения UI об изменениях
