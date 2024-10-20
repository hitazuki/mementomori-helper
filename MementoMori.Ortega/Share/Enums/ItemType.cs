﻿using System.ComponentModel;

namespace MementoMori.Ortega.Share.Enums;

[Description("アイテムの種類")]
public enum ItemType
{
    [Description("なし")] None,
    [Description("無償仮想通貨")] CurrencyFree,
    [Description("有償仮想通貨")] CurrencyPaid,
    [Description("ゲーム内通貨")] Gold,
    [Description("武具")] Equipment,
    [Description("武具の欠片")] EquipmentFragment,
    [Description("キャラクター")] Character,
    [Description("キャラクターの絆")] CharacterFragment,
    [Description("洞窟の加護")] DungeonBattleRelic,
    [Description("アダマンタイト")] EquipmentSetMaterial,
    [Description("n時間分アイテム")] QuestQuickTicket,
    [Description("キャラ育成素材")] CharacterTrainingMaterial,
    [Description("武具強化アイテム")] EquipmentReinforcementItem,
    [Description("交換所アイテム")] ExchangePlaceItem,
    [Description("スフィア")] Sphere,
    [Description("魔装強化アイテム")] MatchlessSacredTreasureExpItem,
    [Description("ガチャチケット")] GachaTicket,
    [Description("宝箱、未鑑定スフィアなど")] TreasureChest,
    [Description("宝箱の鍵")] TreasureChestKey,
    [Description("ボスチケット")] BossChallengeTicket,
    [Description("無窮の塔チケット")] TowerBattleTicket,
    [Description("回復の果実")] DungeonRecoveryItem,
    [Description("プレイヤー経験値")] PlayerExp,
    [Description("フレンドポイント")] FriendPoint,
    [Description("生命樹の雫")] EquipmentRarityCrystal,
    [Description("レベルリンク経験値")] LevelLinkExp,
    [Description("ギルドストック")] GuildFame,
    [Description("ギルド経験値")] GuildExp,
    [Description("貢献メダル")] ActivityMedal,
    [Description("VIP経験値")] VipExp,
    [Description("パネル図鑑解放判定アイテム")] PanelGetJudgmentItem,
    [Description("パネルミッション マス解放アイテム")] UnlockPanelGridItem,
    [Description("パネル図鑑解放アイテム")] PanelUnlockItem,
    [Description("楽曲チケット")] MusicTicket,
    [Description("特別プレイヤーアイコン")] SpecialIcon,
    [Description("アイコンの断片")] IconFragment,
    [Description("タイプ強化アイテム")] GuildTowerJobReinforcementMaterial,
    [Description("リアル景品(グッズ)")] RealPrizeGoods,
    [Description("リアル景品(デジタル)")] RealPrizeDigital,

    [Description("人気投票(ItemId => PopularityVoteMBのId)")]
    PopularityVote,
    [Description("ラッキーチャンスガチャチケット")] LuckyChanceGachaTicket,
    [Description("イベント交換所アイテム")] EventExchangePlaceItem = 50,
    [Description("Stripeクーポン")] StripeCoupon = 1001
}