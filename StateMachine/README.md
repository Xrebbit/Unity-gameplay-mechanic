# State Machine

Универсальная конечная машина состояний без привязки к конкретному персонажу — подходит для AI, анимаций, игровых экранов.

## Как использовать

```csharp
var machine = new StateMachine();
machine.RegisterState(new IdleState());
machine.RegisterState(new ChaseState());
machine.ChangeState<IdleState>();

void Update() => machine.Tick();
```

Каждое состояние реализует `IState` (Enter/Execute/Exit).

## Паттерны

- State pattern
- Generic-методы для типобезопасного переключения состояний
- Dictionary для O(1) доступа к состояниям
