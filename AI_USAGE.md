# AI Usage Disclosure

## Tools Used
- **Claude Sonnet 4.6** (Anthropic) — chat-based code suggestions and explanations

## How I Used It
- **Chat-based code suggestions**: Used Claude to suggest implementations for game systems (dialogue, combat, save/load, camera, map loading). All suggestions were reviewed, understood, and often modified before use.
- **Rubber-ducking**: Discussed architecture decisions, asked for explanations of C# concepts (delta time, IDisposable, LINQ, stack vs heap, GC pressure, best practices in real life game studios etc. ).
- **Debugging**: Pasted errors and asked for explanations of what went wrong.
- **Learning**: Asked Claude to explain concepts before implementing them.

## Fully AI-Generated Files
The following files are substantially AI-generated:
- `Core/VideoPlayer.cs` — FFmpeg integration
- `Core/AudioManager.cs` — NAudio integration
- `Core/SaveSystem.cs` — Save/load system
- `Models/SaveData.cs` — Save data model
- `Models/CombatState.cs` — Combat state data

## Partially AI-Generated Files
Most other files were written collaboratively , while directing the design, asked for explanations of each part, and made modifications throughout. Key files where author contributed significantly:
- `Core/GameLogic.cs` — game flow, quest logic, NPC placement
- `Models/HandymanKnight.cs` — player movement and animation
- `Core/GameMap.cs` — collision system design
- `Models/Quests.cs` — all dialogue content
- `Core/DialogueRenderer.cs` — layout adjustments
