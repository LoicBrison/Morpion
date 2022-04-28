using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorpionLibrary;
// <copyright file="JoueurTest.JoueIA.g.cs">Copyright ©  2022</copyright>
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
    public partial class JoueurTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(JoueurTest))]
        public void JoueIA646()
        {
            Joueur joueur;
            Morpion morpion;
            Case @case;
            joueur = new Joueur("IA");
            morpion = new Morpion((Joueur)null, (Joueur)null);
            morpion.Joue(0, 0);
            @case = this.JoueIA(joueur, morpion);
            Assert.IsNotNull((object)joueur);
            Assert.AreEqual<string>("IA", joueur.Nom);
            Assert.AreEqual<bool>(true, joueur.IsIA);
            Assert.AreEqual<bool>(false, morpion.EstVide(0, 0));
        }
    }
}
