﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using Spect.Net.SpectrumEmu.Tape;
using Spect.Net.SpectrumEmu.Tape.Tzx;
// ReSharper disable PossibleNullReferenceException

namespace Spect.Net.SpectrumEmu.Test.Tape
{
    [TestClass]
    public class TzxPlayerTests
    {
        [TestMethod]
        public void TzxFileCanBeReadSuccessfully()
        {
            // --- Act
            var player = TzxPlayerHelper.CreatePlayer("JestSetWilly.tzx");

            // --- Assert
            player.DataBlocks.Count.ShouldBe(9);
            player.DataBlocks[0].ShouldBeOfType<TzxTextDescriptionDataBlock>();
            for (var i = 1; i < 9; i++)
            {
                player.DataBlocks[i].ShouldBeOfType<TzxStandardSpeedDataBlock>();
            }
        }

        [TestMethod]
        public void InitPlayWorksAsExpected()
        {
            // --- Arrange
            var player = TzxPlayerHelper.CreatePlayer("JestSetWilly.tzx");

            // --- Act
            player.InitPlay(100ul);

            // --- Assert
            player.PlayPhase.ShouldBe(PlayPhase.None);
            player.StartTact.ShouldBe(100ul);
            player.CurrentBlockIndex.ShouldBe(1);
            player.CurrentBlock.ShouldBeOfType<TzxStandardSpeedDataBlock>();
        }

        [TestMethod]
        public void InitPlayInitializesTheFirstDataBlock()
        {
            // --- Arrange
            var player = TzxPlayerHelper.CreatePlayer("JestSetWilly.tzx");

            // --- Act
            player.InitPlay(100ul);

            // --- Assert
            var currentBlock = player.CurrentBlock as TzxStandardSpeedDataBlock;
            currentBlock.ShouldNotBeNull();
            currentBlock.PlayPhase.ShouldBe(PlayPhase.Pilot);
            currentBlock.StartTact.ShouldBe(player.StartTact);
            currentBlock.ByteIndex.ShouldBe(0);
            currentBlock.BitMask.ShouldBe((byte)0x80);
        }

        [TestMethod]
        public void PlayeMovesToNextBlock()
        {
            // --- Arrange
            var player = TzxPlayerHelper.CreatePlayer("JestSetWilly.tzx");
            player.InitPlay(100ul);
            var currentBlock = player.CurrentBlock as TzxStandardSpeedDataBlock;

            // --- Act
            var indexBefore = player.CurrentBlockIndex;
            currentBlock.CompleteBlock();
            var lastTact = currentBlock.LastTact;
            player.GetEarBit(lastTact);
            var indexAfter = player.CurrentBlockIndex;

            // --- Assert
            indexBefore.ShouldBe(1);
            indexAfter.ShouldBe(2);
            currentBlock = player.CurrentBlock as TzxStandardSpeedDataBlock;
            currentBlock.ShouldNotBeNull();
            currentBlock.PlayPhase.ShouldBe(PlayPhase.Pilot);
            currentBlock.StartTact.ShouldBe(lastTact);
            currentBlock.ByteIndex.ShouldBe(0);
            currentBlock.BitMask.ShouldBe((byte)0x80);
        }
    }
}
