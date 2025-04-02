# 🐣 Peck: The forgotten hatchling 🐣

This is the open-source code for **Peck: The forgotten hatchling**.  
A game made for the **JDS Easter jam 2025**.

You can play the game here: **TODO: Insert link when the game is done**

## 🚧 Broken conventions 🚧

The reasoning behind some _very questionable_ decisions in the codebase!

### 🤮 Using public fields instead of properties

Due to this project being developed for _WebGL_ nearly all decisions prioritizes performance.  
Properties adds a redundant method call in the call stack which can create unnecessary overhead in the hot path.  
Therefore we are using public fields instead of properties for code that is expected to cross the hot path.

**Why?**  
Direct data access means:

-   Reduces method call overhead
-   Minimizes stack depth

**Is this good practice?**

Absolutely not.  
But it's the right call for WebGL performance.

### 🤔 Using unprotected Actions instead of proper events

In some places (like the `MomentumController`) we **know** that there will only ever be 1 subscriber for certain events.  
To optimize performance for _WebGL_, we use **direct** `Action` assignments instead of an `event` in those cases.

**Why?**

-   This avoids multicast overhead.
-   Reduces unnecessary memory allocation.

**Is this good practice?**

-   Yes, for performance reasons.
-   No, for extensibility and strict encapsulation.

## 💡 Final thoughts 💡

This project isn't about writing perfect C# code. It's about making a **performant game** within **20 days**.  
If something breaks the best practices but makes the game run **smoother for more players**, that's a **win**.
