// <copyright file="IATest.cs">Copyright ©  2022</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorpionLibrary;

namespace MorpionLibrary.Tests
{
    [TestClass]
    [PexClass(typeof(IA))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IATest
    {

        [PexMethod]
        public Case CalcIA([PexAssumeUnderTest] IA target, Morpion m)
        {
            Case result = target.CalcIA(m);
            return result;
            // TODO: ajouter des assertions à méthode IATest.CalcIA(IA, Morpion)
        }
    }
}
