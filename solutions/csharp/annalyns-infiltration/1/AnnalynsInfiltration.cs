using System;

static class QuestLogic
{
    // 1. Un ataque rápido se puede realizar si el caballero está dormido
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    // 2. Se puede espiar si al menos uno de los tres está despierto
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }

    // 3. Se puede enviar una señal al prisionero si él está despierto y el arquero está dormido
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return prisonerIsAwake && !archerIsAwake;
    }

    // 4. Reglas para liberar al prisionero:
    // - Si el perro está presente: se puede liberar si el arquero está dormido (el perro distrae al caballero).
    // - Si el perro NO está presente: el prisionero debe estar despierto, y tanto el caballero como el arquero deben estar dormidos.
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent)
        {
            return !archerIsAwake;
        }
        else
        {
            return prisonerIsAwake && !knightIsAwake && !archerIsAwake;
        }
    }
}
