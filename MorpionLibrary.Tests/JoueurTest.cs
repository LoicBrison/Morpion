// <copyright file="JoueurTest.cs">Copyright ©  2022</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorpionLibrary;

namespace MorpionLibrary.Tests
{
    [TestClass]
    [PexClass(typeof(Joueur))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class JoueurTest
    {

        [PexMethod]
        public void NomSet([PexAssumeUnderTest] Joueur target, string value)
        {
            target.Nom = value;
            // TODO: ajouter des assertions à méthode JoueurTest.NomSet(Joueur, String)
        }

        [PexMethod]
        public string NomGet([PexAssumeUnderTest] Joueur target)
        {
            string result = target.Nom;
            return result;
            // TODO: ajouter des assertions à méthode JoueurTest.NomGet(Joueur)
        }

        [PexMethod]
        public Case JoueIA([PexAssumeUnderTest] Joueur target, Morpion morpion)
        {
            Case result = target.JoueIA(morpion);
            return result;
            // TODO: ajouter des assertions à méthode JoueurTest.JoueIA(Joueur, Morpion)
        }

        [PexMethod]
        public bool IsIAGet([PexAssumeUnderTest] Joueur target)
        {
            bool result = target.IsIA;
            return result;
            // TODO: ajouter des assertions à méthode JoueurTest.IsIAGet(Joueur)
        }

        [PexMethod]
        public Joueur Constructor(string nom)
        {
            Joueur target = new Joueur(nom);
            return target;
            // TODO: ajouter des assertions à méthode JoueurTest.Constructor(String)
        }
    }
}
