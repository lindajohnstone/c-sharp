using System;
using Xunit;

namespace GameOfLife.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void NoChangeTest()
        {
            // arrange
            //int[][] pattern = new int[4][];
            var pattern = new [] 
            {                
                new[] { 0, 0, 0, 0},                
                new[] { 0, 1, 1, 0},                
                new[] { 0, 1, 1, 0},                
                new[] { 0, 0, 0, 0},            
            };
            //act
            var testPattern = Tick(pattern);
            // assert
            Assert.Equal(testPattern, pattern);
        }
        [Fact]
        public void RuleOneTest()
        {
            
            // Any live cell with fewer than two live neighbours dies, as if by underpopulation.
            // arrange
            var ruleOneAllDead = new []
            {
                new[] { 0, 0, 0, 0},                
                new[] { 0, 1, 0, 0},                
                new[] { 0, 0, 0, 0},                
                new[] { 0, 0, 0, 0},  
            };
            var ruleOne = new []
            {
                new[] { 0, 0, 0, 0},                
                new[] { 0, 0, 0, 0},                
                new[] { 0, 0, 0, 0},                
                new[] { 0, 0, 0, 0},  
            };
            
            // act
                var testPattern = Tick(ruleOneAllDead);
            // assert
            Assert.Equal(ruleOne, testPattern);
        }
        public int[][] Tick(int[][] cell)
        {
            return cell;
        }
    }
}
