// <copyright file="MorpionTest.cs">Copyright ©  2022</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorpionLibrary;

namespace MorpionLibrary.Tests
{
    [TestClass]
    [PexClass(typeof(Morpion))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MorpionTest
    {

        [PexMethod]
        public void AnnuleCoup(
            [PexAssumeUnderTest] Morpion target,
            int x,
            int y
        )
        {
            target.AnnuleCoup(x, y);
            // TODO: ajouter des assertions à méthode MorpionTest.AnnuleCoup(Morpion, Int32, Int32)
        }

        [PexMethod]
        public Case[] CasesGet([PexAssumeUnderTest] Morpion target)
        {
            Case[] result = target.Cases;
            return result;
            // TODO: ajouter des assertions à méthode MorpionTest.CasesGet(Morpion)
        }

        [PexMethod]
        public int CompteCase([PexAssumeUnderTest] Morpion target)
        {
            int result = target.CompteCase();
            return result;
            // TODO: ajouter des assertions à méthode MorpionTest.CompteCase(Morpion)
        }

        [PexMethod]
        public bool EstFini([PexAssumeUnderTest] Morpion target)
        {
            bool result = target.EstFini();
            return result;
            // TODO: ajouter des assertions à méthode MorpionTest.EstFini(Morpion)
        }

        [PexMethod]
        public bool EstVide(
            [PexAssumeUnderTest] Morpion target,
            int x,
            int y
        )
        {
            bool result = target.EstVide(x, y);
            return result;
            // TODO: ajouter des assertions à méthode MorpionTest.EstVide(Morpion, Int32, Int32)
        }

        [PexMethod]
        public Joueur J1Get([PexAssumeUnderTest] Morpion target)
        {
            Joueur result = target.J1;
            return result;
            // TODO: ajouter des assertions à méthode MorpionTest.J1Get(Morpion)
        }

        [PexMethod]
        public void Joue(
            [PexAssumeUnderTest] Morpion target,
            int x,
            int y
        )
        {
            target.Joue(x, y);
            // TODO: ajouter des assertions à méthode MorpionTest.Joue(Morpion, Int32, Int32)
        }

        [PexMethod]
        public Joueur JoueurCourantGet([PexAssumeUnderTest] Morpion target)
        {
            Joueur result = target.JoueurCourant;
            return result;
            // TODO: ajouter des assertions à méthode MorpionTest.JoueurCourantGet(Morpion)
        }

        [PexMethod]
        public void JoueurSuivant([PexAssumeUnderTest] Morpion target)
        {
            target.JoueurSuivant();
            // TODO: ajouter des assertions à méthode MorpionTest.JoueurSuivant(Morpion)
        }

        [PexMethod]
        public Case getCase(
            [PexAssumeUnderTest] Morpion target,
            int x,
            int y
        )
        {
            Case result = target.getCase(x, y);
            return result;
            // TODO: ajouter des assertions à méthode MorpionTest.getCase(Morpion, Int32, Int32)
        }
    }
}
