# Object Pooling

Переиспользование объектов вместо постоянного `Instantiate`/`Destroy` — актуально для пуль, врагов, эффектов и других часто создаваемых объектов.

## Как использовать

1. Повесить `ObjectPool` на пустой GameObject, задать `prefab` и `initialSize`.
2. Получать объект: `ObjectPool.Instance.Get(position, rotation)`.
3. Возвращать в пул: `ObjectPool.Instance.Release(obj)`.

## Паттерны

- Singleton для глобального доступа
- Очередь (Queue) для хранения неактивных объектов
- Ленивое расширение пула, если объектов не хватает
