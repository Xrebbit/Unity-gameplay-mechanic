# Generic Singleton

Базовый класс для быстрого создания синглтонов без дублирования кода в каждом менеджере.

## Как использовать

```csharp
public class GameManager : Singleton<GameManager>
{
    protected override void Awake()
    {
        base.Awake();
    }
}
```

Дальше доступ через `GameManager.Instance`.

## Паттерны

- Generic Singleton
- Автоматическое создание объекта, если его нет на сцене
- `DontDestroyOnLoad` для сохранения между сценами
