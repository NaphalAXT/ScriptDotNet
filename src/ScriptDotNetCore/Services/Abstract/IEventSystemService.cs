﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDotNet2.Services
{
    public interface IEventSystemService
    {
        event EventHandler<ItemEventArgs> ItemInfo;
        event EventHandler<ItemEventArgs> ItemDeleted;
        event EventHandler<SpeechEventArgs> Speech;
        event EventHandler<ObjectEventArgs> DrawGamePlayer;
        event EventHandler<MoveRejectionEventArgs> MoveRejection;
        event EventHandler<DrawContainerEventArgs> DrawContainer;
        event EventHandler<AddItemToContainerEventArgs> AddItemToContainer;
        event EventHandler<AddMultipleItemsInContainerEventArgs> AddMultipleItemsInContainer;
        event EventHandler<RejectMoveItemEventArgs> RejectMoveItem;
        event EventHandler<ObjectEventArgs> UpdateChar;
        event EventHandler<ObjectEventArgs> DrawObject;
        event EventHandler<MenuEventArgs> Menu;
        event EventHandler<MapMessageEventArgs> MapMessage;
        event EventHandler<AllowRefuseAttackEventArgs> AllowRefuseAttack;
        event EventHandler<ClilocSpeechEventArgs> ClilocSpeech;
        event EventHandler<ClilocSpeechAffixEventArgs> ClilocSpeechAffix;
        event EventHandler<UnicodeSpeechEventArgs> UnicodeSpeech;
        event EventHandler<Buff_DebuffSystemEventArgs> Buff_DebuffSystem;
        event EventHandler<EventArgs> ClientSendResync;
        event EventHandler<CharAnimationEventArgs> CharAnimation;
        event EventHandler<EventArgs> ICQDisconnect;
        event EventHandler<EventArgs> ICQConnect;
        event EventHandler<ICQIncomingTextEventArgs> ICQIncomingText;
        event EventHandler<ICQErrorEventArgs> ICQError;
        event EventHandler<IncomingGumpEventArgs> IncomingGump;
        event EventHandler<EventArgs> Timer1;
        event EventHandler<EventArgs> Timer2;
        event EventHandler<WindowsMessageEventArgs> WindowsMessage;
        event EventHandler<SoundEventArgs> Sound;
        event EventHandler<DeathEventArgs> Death;
        event EventHandler<QuestArrowEventArgs> QuestArrow;
        event EventHandler<PartyInviteEventArgs> PartyInvite;
        event EventHandler<MapPinEventArgs> MapPin;
        event EventHandler<GumpTextEntryEventArgs> GumpTextEntry;
        event EventHandler<GraphicalEffectEventArgs> GraphicalEffect;
        event EventHandler<IRCIncomingTextEventArgs> IRCIncomingText;
        event EventHandler<MessangerIncomingTextEventArgs> MessangerIncomingText;
    }
}
