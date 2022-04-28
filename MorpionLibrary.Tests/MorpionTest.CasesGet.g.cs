using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorpionLibrary;
// <copyright file="MorpionTest.CasesGet.g.cs">Copyright ©  2022</copyright>
// <auto-generated>
// Ce fichier contient des tests générés automatiquement.
// Ne modifiez pas ce fichier manuellement.
// 
// Si le contenu de ce fichier est obsolète, vous pouvez le supprimer.
// Par exemple, s'il n'est plus compilé.
//  </auto-generated>
using System;

namespace MorpionLibrary.Tests
{
    public partial class MorpionTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(MorpionTest))]
        public void CasesGet75()
        {
            Joueur joueur;
            Morpion morpion;
            Case[] cases;
            joueur = new Joueur("IA");
            morpion = new Morpion(joueur, (Joueur)null);
            morpion.Joue(0, 0);
            cases = this.CasesGet(morpion);
            Assert.IsNotNull((object)morpion);
            Assert.IsNotNull(morpion.JoueurCourant);
            Assert.AreEqual<string>("IA", morpion.JoueurCourant.Nom);
            Assert.AreEqual<bool>(true, morpion.JoueurCourant.IsIA);
            Assert.IsNotNull(morpion.J1);
            Assert.IsTrue(object.ReferenceEquals(morpion.J1, morpion.JoueurCourant));
            Assert.IsNotNull(morpion.Cases);
            Assert.AreEqual<int>(9, morpion.Cases.Length);
            Assert.IsNotNull((object)(morpion.Cases[0]));
            Assert.IsNotNull(morpion.Cases[0].MarqueePar);
            Assert.IsTrue
                (object.ReferenceEquals(morpion.Cases[0].MarqueePar, morpion.JoueurCourant));
            Assert.AreEqual<int>(0, morpion.Cases[0].GetX);
            Assert.AreEqual<int>(0, morpion.Cases[0].GetY);
            Assert.IsNotNull((object)(morpion.Cases[1]));
            Assert.IsNull(morpion.Cases[1].MarqueePar);
            Assert.AreEqual<int>(1, morpion.Cases[1].GetX);
            Assert.AreEqual<int>(0, morpion.Cases[1].GetY);
            Assert.IsNotNull((object)(morpion.Cases[2]));
            Assert.IsNull(morpion.Cases[2].MarqueePar);
            Assert.AreEqual<int>(2, morpion.Cases[2].GetX);
            Assert.AreEqual<int>(0, morpion.Cases[2].GetY);
            Assert.IsNotNull((object)(morpion.Cases[3]));
            Assert.IsNull(morpion.Cases[3].MarqueePar);
            Assert.AreEqual<int>(0, morpion.Cases[3].GetX);
            Assert.AreEqual<int>(1, morpion.Cases[3].GetY);
            Assert.IsNotNull((object)(morpion.Cases[4]));
            Assert.IsNull(morpion.Cases[4].MarqueePar);
            Assert.AreEqual<int>(1, morpion.Cases[4].GetX);
            Assert.AreEqual<int>(1, morpion.Cases[4].GetY);
            Assert.IsNotNull((object)(morpion.Cases[5]));
            Assert.IsNull(morpion.Cases[5].MarqueePar);
            Assert.AreEqual<int>(2, morpion.Cases[5].GetX);
            Assert.AreEqual<int>(1, morpion.Cases[5].GetY);
            Assert.IsNotNull((object)(morpion.Cases[6]));
            Assert.IsNull(morpion.Cases[6].MarqueePar);
            Assert.AreEqual<int>(0, morpion.Cases[6].GetX);
            Assert.AreEqual<int>(2, morpion.Cases[6].GetY);
            Assert.IsNotNull((object)(morpion.Cases[7]));
            Assert.IsNull(morpion.Cases[7].MarqueePar);
            Assert.AreEqual<int>(1, morpion.Cases[7].GetX);
            Assert.AreEqual<int>(2, morpion.Cases[7].GetY);
            Assert.IsNotNull((object)(morpion.Cases[8]));
            Assert.IsNull(morpion.Cases[8].MarqueePar);
            Assert.AreEqual<int>(2, morpion.Cases[8].GetX);
            Assert.AreEqual<int>(2, morpion.Cases[8].GetY);
        }
    }
}
