using FluentAssertions;
using System;
using Xunit;

namespace Utils.Tests.Helpers
{
    public class ArrayHelpersTests
    {
        [Fact]
        public void CombinarDosArrays_AmbosNull_DevuelveArrayVacio()
        {
            //arrange
            //act

            var resultado = ArrayHelpers.CombinarDosArrays(null, null);

            //assert

            resultado.Should().BeEquivalentTo(Array.Empty<int>());
        }

        [Fact]
        public void CombinarDosArrays_SegundoNull_DevuelveValoresDelPrimero()
        {
            //arrange
            //act

            var resultado = ArrayHelpers.CombinarDosArrays(new int[] { 1, 3, 8 }, null);

            //assert

            resultado.Should().BeEquivalentTo(new int[] { 1, 3, 8 });
        }

        [Fact]
        public void CombinarDosArrays_PrimeroNull_DevuelveValoresDelPrimero()
        {
            //arrange
            //act

            var resultado = ArrayHelpers.CombinarDosArrays(null, new int[] { 1, 3, 8 });

            //assert

            resultado.Should().BeEquivalentTo(new int[] { 1, 3, 8 });
        }

        [Fact]
        public void CombinarDosArrays_SinRepetidos_DevuelveValores()
        {
            //arrange
            //act

            var resultado = ArrayHelpers.CombinarDosArrays(new int[] { 2, 4, 11 }, new int[] { 1, 3, 8 });

            //assert

            resultado.Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 8, 11 });
        }

        [Fact]
        public void CombinarDosArrays_ConRepetidos_DevuelveValores()
        {
            //arrange
            //act

            var resultado = ArrayHelpers.CombinarDosArrays(new int[] { 2, 4, 11 }, new int[] { 4, 3, 8 });

            //assert

            resultado.Should().BeEquivalentTo(new int[] { 2, 3, 4, 8, 11 });
        }

        [Fact]
        public void CombinarDosArrays_PrimeroMasLargo_DevuelveValores()
        {
            //arrange
            //act

            var resultado = ArrayHelpers.CombinarDosArrays(new int[] { 2, 4, 7, 8, 9, 11, 15 }, new int[] { 4, 3, 8 });

            //assert

            resultado.Should().BeEquivalentTo(new int[] { 2, 3, 4, 7, 8, 9, 11, 15 });
        }

        [Fact]
        public void CombinarDosArrays_SegundoMasLargo_DevuelveValores()
        {
            //arrange
            //act

            var resultado = ArrayHelpers.CombinarDosArrays(new int[] { 4, 3, 8 }, new int[] { 2, 4, 7, 8, 9, 11, 15 });

            //assert

            resultado.Should().BeEquivalentTo(new int[] { 2, 3, 4, 7, 8, 9, 11, 15 });
        }
    }
}