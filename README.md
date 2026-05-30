# In Your Service

A top-down pixel RPG where you play as Handyman the Knight , a disgraced knight cast out of his castle and tasked with performing three honourable deeds to reclaim his honour.

## Gameplay
- Walk around the kingdom and find 3 NPCs to help
- Make moral choices in dialogue that affect your honour level
- Return to the castle for a final confrontation with Sir Aldric
- Your honour determines the ending dialogue
- The game always ends the same way — but how you got there matters

## Controls
| Key | Action |
|-----|--------|
| WASD / Arrow keys | Move |
| E | Interact / Advance dialogue |
| 1 / 2 | Dialogue choices |
| Click | Attack (during combat) |
| F5 | Save game |

## Build & Run

### Requirements
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- FFmpeg shared DLLs (see below)

### FFmpeg Setup (required for ending video)
1. Download FFmpeg full shared build from https://www.gyan.dev/ffmpeg/builds/
2. Extract and copy the `.dll` files into a folder called `ffmpeg/` in the project root
3. The folder should contain: `avcodec-62.dll`, `avformat-62.dll`, `avutil-60.dll`, etc.

### Running
