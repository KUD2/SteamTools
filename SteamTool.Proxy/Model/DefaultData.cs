﻿using SteamTool.Proxy.Properties;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace SteamTool.Proxy.Model
{
    public static class DefaultData
    {
        public static List<ProxyDomainModel> ProxyDomains { get; } = new List<ProxyDomainModel>
        {
            new ProxyDomainModel{
                Name=Resources.SteamStore,
                Domain = "steampowered.com",
                ProxyDomain = "steampowered.com",
                Hosts = new List<string>{ "steamcommunity.com", "www.steamcommunity.com"},
                DomainTag = DomainTag.SteamStore,
                IsEnbale= true,
            },
            new ProxyDomainModel{
                Name=Resources.SteamCommunity,
                Domain = "steamcommunity.com",
                ProxyDomain = "steamcommunity-a.akamaihd.net",
                Hosts = new List<string>{ "store.steampowered.com", "api.steampowered.com"},
                DomainTag = DomainTag.SteamCommunity,
                IsEnbale= true,
            },
            new ProxyDomainModel{
                Name=Resources.SteamImage,
                Domain = "steamcdn-a.akamaihd.net",
                ProxyDomain = "steamcommunity-a.akamaihd.net",
                Hosts = new List<string>{ "steamcdn-a.akamaihd.net"},
                DomainTag = DomainTag.SteamImage,
                IsEnbale= true,
            },
            new ProxyDomainModel{
                Name=Resources.SteamChat,
                Domain = "steam-chat.com",
                ProxyDomain = "steamcommunity-a.akamaihd.net",
                Hosts = new List<string>{ "steam-chat.com"},
                DomainTag = DomainTag.SteamChat,
                IsEnbale= true,
            },
            new ProxyDomainModel{
                Name=Resources.Discord,
                Domain = "discordapp.com",
                ProxyDomain = "steamcommunity-a.akamaihd.net",
                Hosts = new List<string>{
                    "discordapp.com",
                    "dl.discordapp.net",
                    "media.discordapp.net",
                    "images-ext-2.discordapp.net",
                    "images-ext-1.discordapp.net",
                    "support.discordapp.com",
                    "url9177.discordapp.com",
                    "canary-api.discordapp.com",
                    "cdn-ptb.discordapp.com",
                    "ptb.discordapp.com",
                    "status.discordapp.com",
                    "cdn-canary.discordapp.com",
                    "cdn.discordapp.com",
                    "streamkit.discordapp.com",
                    "i18n.discordapp.com" ,
                    "url9624.discordapp.com",
                    "url7195.discordapp.com",
                    "merch.discordapp.com",
                    "printer.discordapp.com",
                    "canary.discordapp.com",
                    "apps.discordapp.com",
                    "pax.discordapp.com",
                },
                DomainTag = DomainTag.SteamChat,
                IsEnbale= true,
            },
            new ProxyDomainModel{
                Name=Resources.Twitch,
                Domain = "twitch.tv",
                ProxyDomain = "steamcommunity-a.akamaihd.net",
                Hosts = new List<string>{
                "twitch.tv",
                "www.twitch.tv",
                "m.twitch.tv",
                "app.twitch.tv",
                "music.twitch.tv",
                "badges.twitch.tv",
                "blog.twitch.tv",
                "inspector.twitch.tv",
                "stream.twitch.tv",
                "dev.twitch.tv",
                "clips.twitch.tv",
                "spade.twitch.tv",
                "gql.twitch.tv",
                "vod-secure.twitch.tv",
                "vod-storyboards.twitch.tv",
                "trowel.twitch.tv",
                "countess.twitch.tv",
                "extension-files.twitch.tv",
                "vod-metro.twitch.tv",
                "pubster.twitch.tv",
                "help.twitch.tv",
                "passport.twitch.tv",
                "id.twitch.tv",
                "link.twitch.tv",
                "id-cdn.twitch.tv",
                "player.twitch.tv",
                "api.twitch.tv",
                "cvp.twitch.tv",
                "pubsub-edge.twitch.tv",
                "clips-media-assets2.twitch.tv",
                "client-event-reporter.twitch.tv",
                "gds-vhs-drops-campaign-images.twitch.tv",
                "us-west-2.uploads-regional.twitch.tv",
                "assets.help.twitch.tv",
                "discuss.dev.twitch.tv",
                "irc-ws.chat.twitch.tv",
                "irc-ws-r.chat.twitch.tv",
                "platform.twitter.com",
                "usher.ttvnw.net",
                },
                DomainTag = DomainTag.SteamChat,
                IsEnbale= true,
            },
            new ProxyDomainModel{
                Name=Resources.OriginDownload,
                Domain = "origin-a.akamaihd.net",
                ProxyDomain = "origin-a.akamaihd.net",
                Hosts = new List<string>{ "origin-a.akamaihd.net"},
                DomainTag = DomainTag.SteamChat,
                IsEnbale= true,
            },
            new ProxyDomainModel{
                Name=Resources.OriginDownload,
                Domain = "static3.cdn.ubi.com",
                ProxyDomain = "static3.cdn.ubi.com",
                Hosts = new List<string>{ "static3.cdn.ubi.com"},
                DomainTag = DomainTag.SteamChat,
                IsEnbale= true,
            },
            new ProxyDomainModel{
                Name=Resources.OriginDownload,
                Domain = "www.google.com",
                ProxyDomain = "kh.google.com",
                Hosts = new List<string>{ "www.google.com"},
                DomainTag = DomainTag.SteamChat,
                IsEnbale= true,
            },
        };

    }
}