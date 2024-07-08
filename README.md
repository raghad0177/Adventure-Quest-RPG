# AdventureQuestRPG

AdventureQuestRPG is a text-based role-playing game (RPG) implemented in C#. Players engage in battles against various monsters and bosses, utilizing items to enhance their abilities and survive through multiple levels.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)

## Introduction

AdventureQuestRPG simulates an adventure where players battle monsters and bosses using a turn-based system. It includes character classes, items, and randomized encounters for an engaging gameplay experience.

## Features

- **Characters:**
  - Playable characters: Ibrahim and Raghad, each with unique stats and abilities.
  - Non-playable characters (NPCs): Various monsters like Giant Spiders, Goblins, Ghosts, Dragons, and the formidable boss, Lucifer.

- **Battle System:**
  - Turn-based combat between players and monsters.
  - Dynamic calculation of damage based on attack power and defense stats.
  - Random item drops upon defeating enemies.

- **Inventory System:**
  - Manage and use items like swords (increase attack power), armor (increase defense), and vitality items (restore health).

## Getting Started

To run AdventureQuestRPG on your local machine, follow these steps:

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/AdventureQuestRPG.git
   cd AdventureQuestRPG
2. **Compile and run:
Open the solution in Visual Studio or compile directly using .NET CLI:
dotnet build
dotnet run

## Usage
Initial Setup:

Choose a map and navigate through different levels by interacting with prompts.
Use items before battles to enhance character stats.
Battle Mechanics:

Engage in turn-based combat against monsters and bosses.
Monitor health, attack power, and defense during battles.
Item Management:

View inventory status and decide when to use items based on battle conditions.

## Testing
AdventureQuestRPG includes unit tests to ensure functionality and reliability. To run tests:
dotnet test

## Contributing
Contributions are welcome! Fork the repository and submit a pull request with your enhancements. Make sure to follow the project's coding conventions and include relevant test cases for new features.

## License
This project is licensed under the MIT License - see the LICENSE file for details.
