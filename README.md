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


# Toggle Commands
**Note** Be sure to use `toggle` before every command in this area

Command | parameters | usage | required permissions | details
------------ | ------------- | ------------- | ------------- | -------------
`blank` | `none` | `;toggle` | GuildPermission.ManageChannels | Show's things you can toggle
joinrole | `none` | `;toggle joinrole` | GuildPermission.ManageChannels | Enable/Disable joinrole (adds role on join)
Antinv | `none` | `;toggle antinv` | GuildPermission.ManageChannels | Enable/Disable antinv (anti invite)
Bans | `none` | `;toggle bans` | GuildPermission.ManageChannels | Enable/Disable bans (tied to adminchannel)
Joins | `none` | `;toggle joins` | GuildPermission.ManageChannels | Enable/Disable joins (join logging to joinchannel)
Leaves | `none` | `;toggle leaves` | GuildPermission.ManageChannels | Enable/Disable leaves (leave logging to leavechannel)

# Self-Assignable Roles
**GENERAL** Don't add any roles with high permissions in here or they `will` be abused by some angry member. Keep in mind that when you remove a role from the self-assignable roles list, someone that has the role cannot remove it from themselfs using the `;iamnot` command!

| Command       | Parameter    | Example            | required permissions   | Output                                                                                                                                                                       |
|---------------|--------------|--------------------|--------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Asar     | rolename | `;asar test`    | Manage Roles | Adds the specified role to the self assignable roles. Other users can then add them to themselfs using the bot                                                               |
| rsar  | rolename | `;rsar test` | Manage Roles | Removes the specified role from the self assignable roles. Keep in mind that afterwards users that have that role cannot remove it from themselfs using the $iamnot command! |
| iam         | rolename | `;iam test`        | *none*       | Adds the specified role to yourself                                                                                                                                          |
| iamnot      | rolename | `;iamnot test`     | *none*       | Removes the specified role from yourself                                                                                                                                     |
| lsar | *none*       | `;lsar`     | *none*       | list's all Self Assignable roles in the server                                                                                                   |

# Audio Commands

Command | parameters | usage | required permissions | details
------------ | ------------- | ------------- | ------------- | -------------
queue | `none` | `;queue` or `q` | `none` | Show's the queue in the server
q add | yt link or search term | `;q add youtube.com/video` or `;q add videoname` | `none` | Add a song to the queue
q pl | yt playlist link | `;q pl youtubeplaylist-link` | `none` | try to add the 10 first videos in the playlist to the queue
np | `none` | `;np` | `none` | show's what song is playing and how far along it is
q all | `none` | `;q all` | `none` | play all songs in server's music folder
q skip | `none` | `;q skip` | `none` | skip current song
q clear | `none` | `q clear` | `none` | clear the entire queue
q play | `none` | `;q play` | `none` | start the music
songs | `none` | `;songs` | `none` | show server's music folder
delet | number | `;delet 0` | GuildPermission.ManageMessages | delet song from music folder
delall | `none` | `;delall` | GuildPermission.ManageMessages | delet all songs from music folder
mjoin | `none` | `;mjoin` | `none` | join voice channel
mleave | `none` | `;mleave` | `none` | leave voice channel
