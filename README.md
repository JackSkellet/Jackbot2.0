# Jackbot 2.0
Discord bot using Discord.Net 1.0.2. And tbh, it's a mess of other bots smashed into one, with my own editions.
This is just something for me to learn and do as a hobby.

parameters inside `[]` are optional.
parameters inside `()` are the different ones you can use
parameters that have a `*` can be multiple of that parameter.
Default prefix is `;`.
If you dont want jackbot to lock some channels make sure to disable `manage permissions` in those channels,  jackbot will give you a 403 error when used, but it will lock the other channels.
Using Welcome and Leave commands you can use {User} to get the user who joined or left, and {Guild} to get the guild name
To make leve and join messages appear, set the channel using `;setchannel joinchannel #channel` or `;setchannel leavechannel #channel` 
Adminchannel is where bans/unbans/kick's (only with command) and muterole logging will be posted

# Moderation Commands
Command | parameters | usage | required permissions | details
------------ | ------------- | ------------- | ------------- | -------------
Forceban | User [reason] | `;forceban @user spambot in another server` | GuildPermission.BanMembers | Bans users that are not in the server
Ban | User [reason] | `;ban @user annoying` | GuildPermission.BanMembers | Ban a user from the server
kick | User [reason] | `;kick @user warning` | GuildPermission.KickMembers | Kick's the user from the server
Prune | `*`[User] [Ammount] | `;prune @user 50` |  GuildPermission.ManageMessages | Clean the chat
ahh | `none` | `;ahh` | `none` | clean the bot's messages
lock | [Channel] | `;lock` or `;lock #channel` | GuildPermission.ManageChannels | Lock the channel so no messages can be sent - channels with manage permissions disabled
unlock | [Channel] | `;unlock` or `;unlock #channel` | GuildPermission.ManageChannels | Unlock the channel so messages can be sent - channels with manage permissions disabled
slock | `none` | `;slock` | GuildPermission.ManageChannels | Lock the entire server - channels with manage permissions disabled
sunlock | `none` | `;sunlock` | GuildPermission.ManageChannels | Unlock the entire server - channels with manage permissions disabled
mute | User [reason] | `;mute @user being mean` | GuildPermission.ManageMessages | mutes a user, mute also has anti evade, so if they leave and rejoin the role will be automatically re added
mute | User | `;unmute @user` | GuildPermission.ManageMessages | unmutes a user


# Guild Commands
Command | parameters | usage | required permissions | details
------------ | ------------- | ------------- | ------------- | -------------
Prefix | [string] | `;prefix`or `;prefix >>` | `none`| Check the guild prefix or set a new one
Welcome | [string] | `;welcome` or `;welcome hi` | GuildPermission.ManageChannels | set a welcome message
Leave | [string] | `;leave` or `;leave bye` | GuildPermission.ManageChannels | set a Leave message
Settings | `none` | `;settings` | `none` | Check This server's settings
Setchannel | (Adminchannel, Joinchannel, Leavechannel) Channel | `;setchannel adminchannel #channel` | GuildPermission.ManageChannels | set channels for use
Setmuterole | rolename | `;setmuterole muted` | GuildPermission.ManageRoles | set's a muterole for the server, jackbot takes care of the perms
Setjoinrole | rolename | `;setjoinrole newb` | GuildPermission.ManageRoles | set's a joinrole for the server, be sure to toggle joinroles for it to take effect

Be sure to use `toggle` before every command in this area
# Toggle Commands
Command | parameters | usage | required permissions | details
------------ | ------------- | ------------- | ------------- | -------------
`blank` | `none` | `;toggle` | GuildPermission.ManageChannels | Show's things you can toggle
joinrole | `none` | `;toggle joinrole` | GuildPermission.ManageChannels | Enable/Disable joinrole (adds role on join)
Antinv | `none` | `;toggle antinv` | GuildPermission.ManageChannels | Enable/Disable antinv (anti invite)
Bans | `none` | `;toggle bans` | GuildPermission.ManageChannels | Enable/Disable bans (tied to adminchannel)
Joins | `none` | `;toggle joins` | GuildPermission.ManageChannels | Enable/Disable joins (join logging to joinchannel)
Leaves | `none` | `;toggle leaves` | GuildPermission.ManageChannels | Enable/Disable leaves (leave logging to leavechannel)
