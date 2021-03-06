// <copyright file="CaseTest.cs">Copyright ©  2022</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorpionLibrary;

namespace MorpionLibrary.Tests
{
    [TestClass]
    [PexClass(typeof(Case))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CaseTest
    {

        [PexMethod]
        public void MarqueeParSet([PexAssumeUnderTest] Case target, Joueur value)
        {
            target.MarqueePar = value;
            // TODO: ajouter des assertions à méthode CaseTest.MarqueeParSet(Case, Joueur)
        }
    }
}
