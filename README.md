# GPCI C#

SA-MP's GPCI function implemented in C#, based on [Renegade334](https://github.com/Renegade334/gpci-js)'s implementation in Javascript

![image](https://github.com/VIRUXE/samp-gpci-csharp/assets/1616657/e675ba96-ff84-4a60-92b6-37c4bc92ee48)

## Overview

The full name for this function is apparently `GetPlayerComputerId`. But this was never documented, nor was the function itself.

For some reason, SA-MP's creator at the time implemented this function and kept it as a secret.

The idea behind this was to be a sort of unique ID to identify a player. Although that wasn't really the case as time went by, because people started figuring out how it worked. So multiple players ended up having the same hash.

Anyhow, this, and an IP were the only things used in SA-MP at the time to _actually_ keep bad actors from rejoining servers.

## Why care?

Well, as in the game, this was also useful to identify players from outside of the gameserver. When for example, using a _launcher_ or an external _anti-cheat_.
