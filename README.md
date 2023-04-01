# Black Revival
[![AGPL License](http://img.shields.io/badge/license-AGPL-brightgreen.svg)](https://opensource.org/licenses/AGPL-3.0)

[![Discord Chat](https://dcbadge.vercel.app/api/server/XEbTFqB)](https://discord.gg/XEbTFqB)
--------------

## Black Survival Server Emulation Suite ##

This server software to revive a now defunct game, that was taken offline due to the niche popularity of the game. 

We are striving to bring back this game for those people who loved it. 

## Setup Instructions ##

This server requires several steps

1. You must replace your Assembly-CSharp.dll in steamapps\common\Black Survival\BlackSurvival_Data\Managed with the included one. 
2. Put steam_appid.txt and .local files in your steamapps\common\Black Survival\ folder
3. Download the Patch server files from [this link](https://mega.nz/file/kNZUmY6Y#x_tq2oACNSyL_uArldZ74SWd4gGPq5hh8hXlFBcZxck)
4. Extract them to <Repo>\BlackRevivalServer\LIVE\11.2.00\Windows64 where bundlelist.txt resides
5. Open visual studio.
5. Build the server then run from visual studio. 
6. Then run the game. 

It should automatically connect to your server. 

## Current Progress ##

The current progress of the server is farily incomplete in its implementation. 

It needs quite a bit of work to get to a playable state, Currently all WebAPI data is statically served. 

There is no database implementation but the start of one is in progress. 

The WebSocket servers for the actual game server are mostly static as well. 

I am releasing this now as the players want to see some progress, and i don't have the time to dedicate to this project anymore :( 