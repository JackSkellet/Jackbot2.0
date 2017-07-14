# Jackbot 2.0
Discord bot using Discord.Net 1.0.2. And tbh, it's a mess of other bots smashed into one, with my own editions.
This is just something for me to learn and do as a hobby.

parameters inside `[]` are optional.
parameters that have a `*` can be multiple of that parameter.
Default prefix is `;`.
If you dont want jackbot to lock some channels make sure to disable `manage permissions` in those channels,  jackbot will give you a 403 error when used, but it will lock the other channels.

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

